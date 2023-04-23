﻿using GameWebsite.Service.Models.Categories;
using GameWebsite.Service.Models.Posts;
using GameWebsite.Service.Models.Users;
using GameWebsite.Services.Categories;
using GameWebsite.Services.Posts;
using GameWebSite.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GameWebsite.Web.Areas.Administration.Controllers
{
    [Route("Administration/Posts")]
    public class PostAdministrationController : BaseAdministrationController
    {
        private readonly IPostService service;
        private readonly ICategoryService categoryService;
        public PostAdministrationController(IPostService service, ICategoryService categoryService)
        {
            this.service = service;
            this.categoryService = categoryService;
        }
        public IActionResult Index(long id)
        {
            List<PostDto> posts = this.service.GetAllPosts().ToList();
            posts = posts.FindAll(post => post.Category.Id == id);
            PostViewData postViewData = new PostViewData(id, posts);
            return View(postViewData);
        }
        [HttpGet("Posts/Create/{categoryId}")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("Posts/Create/{categoryId}")]
        public async Task<IActionResult> Create(long categoryId, PostDto postDto)
        {
            postDto.CreatedBy = new GameWebsiteUserDto
            {
                Id = this.User.FindFirst(ClaimTypes.NameIdentifier).Value
            };
            postDto.Category = new CategoryDto
            {
                Id = categoryId,
                CreatedBy = new GameWebsiteUserDto{ }
            };
            await this.service.CreatePost(postDto);
            return Redirect("/Administration/Categories");
        }
        [Route("Posts/Delete/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await this.service.DeletePost(id);

            return Redirect("/Administration/Categories");
        
        }
        [Route("Posts/Edit/{id}")]
        [HttpGet("Posts/Edit/{id}")]
        public async Task<IActionResult> Edit(long id)
        {
            return View(await this.service.GetPostById(id));
        }
        [Route("Posts/Edit/{id}")]
        [HttpPost("Posts/Edit/{id}")]
        public async Task<IActionResult> Edit(long id, PostDto postDto)
        {
            await this.service.UpdatePost(id, postDto);

            return Redirect("/Administration/Categories");
        }
    }
}
