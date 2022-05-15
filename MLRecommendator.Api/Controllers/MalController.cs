﻿using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MLRecommendator.Database;
using MLRecommendator.Database.Models;
using Newtonsoft.Json;

namespace MLRecommendator.Api.Controllers; 

[Route("api/[controller]")]
[ApiController]
public class MalController : ControllerBase {
    private readonly HttpClient _client;
    private readonly MalContext _context;
    public MalController(MalContext context, IConfiguration configuration) {
        _client = new HttpClient {
            BaseAddress = new Uri("https://api.myanimelist.net/v2/")
        };
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _client.DefaultRequestHeaders.Add("X-MAL-CLIENT-ID", configuration["MalToken"]);
        _context = context;
    }
    // GET: api/Mal
    [HttpGet]
    public async Task<ActionResult> Get() {
        var message = await _client.GetAsync("anime/ranking?ranking_type=all&limit=500&fields=id,title,start_date,end_date,mean,rank,popularity,num_list_users,num_scoring_users,nsfw,status,genres,num_episodes,source,average_episode_duration,rating,studios");
        if (!message.IsSuccessStatusCode) return BadRequest();
        var content = await message.Content.ReadAsStringAsync();
        dynamic json = JsonConvert.DeserializeObject(content)!;
        var data = json.data;
        foreach (var node in data) {
            var anime = node.node;
            var series = new Anime {
                Id = anime.id,
                Title = anime.title,
                Mean = anime.mean,
                Rank = anime.rank,
                Popularity = anime.popularity,
                UsersNumber = anime.num_list_users,
                UsersScoringNumber = anime.num_scoring_users,
                Nsfw = anime.nsfw,
                EpisodeNumber = anime.num_episodes,
                StartDate = anime.start_date,
                EndDate = anime.end_date,
                Status = anime.status,
                Source = anime.source,
                AverageEpisodeDuration = anime.average_episode_duration,
                Rating = anime.rating
            };
            var sb = new StringBuilder();
            try {
                foreach (var genre in anime.genres) sb.Append($"{genre.name}|");
                sb.Length--;
                series.Genres = sb.ToString();
            }
            catch (Exception) {
                // ignored
            }
            sb.Clear();
            try {
                foreach (var studio in anime.studios) sb.Append($"{studio.name}|");
                sb.Length--;
                series.Studios = sb.ToString();
            }
            catch (Exception) {
                // ignored
            }
            _context.Add(series);
        }
        await _context.SaveChangesAsync();
        return Ok(content);
    }

    // GET api/Mal/5
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id) {
        var message = await _client.GetAsync($"anime/{id}?fields=id,title,start_date,end_date,mean,rank,popularity,num_list_users,num_scoring_users,nsfw,status,genres,num_episodes,source,average_episode_duration,rating");
        if (message.IsSuccessStatusCode)
            return Ok(message.Content.ReadAsStringAsync().Result);
        return BadRequest();
    }
}