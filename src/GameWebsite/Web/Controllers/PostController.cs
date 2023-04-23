﻿using GameWebsite.Data.Models;
using GameWebsite.Service.Models.Categories;
using GameWebsite.Service.Models.Posts;
using GameWebsite.Service.Models.Users;
using GameWebsite.Services.Posts;
using GameWebSite.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace GameWebsite.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService service;
        public PostController(IPostService service)
        {
            this.service = service;
        }
        public IActionResult Index(long id)
        {
            List<PostDto> posts = this.service.GetAllPosts().ToList();
            posts = posts.FindAll(post => post.Category.Id == id);
            PostViewData postViewData = new PostViewData(id, posts);
            return View(postViewData);
        }

        [Authorize(Roles = "User")]
        [HttpGet("Create/{categoryId}")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "User")]
        [Route("Create/{categoryId}")]
        [HttpPost("Create/{categoryId}")]
        public async Task<IActionResult> Create(long categoryId, PostDto postDto)
        {
            postDto.CreatedBy = new GameWebsiteUserDto
            {
                Id = this.User.FindFirst(ClaimTypes.NameIdentifier).Value
            };
            postDto.Category = new CategoryDto
            {
                Id = categoryId,
                CreatedBy = new GameWebsiteUserDto { }
            };
            await this.service.CreatePost(postDto);
            return Redirect("/Home");
        }

        [Authorize(Roles = "User")]
        [HttpGet("MyPosts/{id}")]
        public IActionResult MyPosts(string id)
        {
            List<PostDto> posts = this.service.GetAllPosts().ToList();
            List<PostDto> myPosts = posts.FindAll(post => post.CreatedBy.Id == id);
            return View(myPosts);
        }

        [Authorize(Roles = "User")]
        [HttpGet("Edit/{id}")]
        public async Task<IActionResult> Edit(long id)
        {
            return View(await this.service.GetPostById(id));
        }

        [Authorize(Roles = "User")]
        [HttpPost("Edit/{id}")]
        public async Task<IActionResult> Edit(long id, PostDto postDto)
        {
            await this.service.UpdatePost(id, postDto);

            return Redirect("/Home");
        }

        [Authorize(Roles = "User")]
        [Route("MyPosts/Delete/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await this.service.DeletePost(id);

            return Redirect("/Home");

        }
    }
}
