using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APiApp.Controllers
{
    public class AdminController : ApiController
    {
        //NEWS######################################################################
        [Route("api/News/All")]
        [HttpGet]
        public List<NewsModel> GetAll()
        {
            return NewsService.Get();
        }

        [Route("api/News/Create")]
        [HttpPost]
        public void Add(NewsModel n)
        {
            NewsService.Add(n);
        }

        [Route("api/News/Edit")]
        [HttpPost]
        public void Edit(NewsModel n)
        {
            NewsService.Edit(n);
        }

        [Route("api/News/Delete")]
        [HttpPost]
        public void Delete(NewsModel n)
        {
            NewsService.Delete(n);
        }

        //Category######################################################################


        [Route("api/Category/All")]
        [HttpGet]
        public List<CategoryModel> GetAllC()
        {
            return CategoryService.Get();
        }

        [Route("api/Category/Create")]
        [HttpPost]
        public void AddC(CategoryModel n)
        {
            CategoryService.Add(n);
        }

        [Route("api/Category/Edit")]
        [HttpPost]
        public void EditC(CategoryModel n)
        {
            CategoryService.Edit(n);
        }

        [Route("api/Category/Delete")]
        [HttpPost]
        public void DeleteC(CategoryModel n)
        {
            CategoryService.Delete(n);
        }



        //NEWS(Comment)######################################################################

        [Route("api/Comment/All")]
        [HttpGet]
        public List<CommentModel> GetAllComment()
        {
            return CommentService.Get();
        }

        [Route("api/Comment/All/{id}")]
        [HttpGet]
        public List<CommentModel> GetAllComment(int id)
        {
            return CommentService.Get(id);
        }


        //NEWS(Reaction)######################################################################


        [Route("api/Reaction/All")]
        [HttpGet]
        public List<ReactionModel> GetAllReaction()
        {
            return ReactionService.Get();
        }

        [Route("api/Reaction/All/{id}")]
        [HttpGet]
        public List<ReactionModel> GetAllReaction(int id)
        {
            return ReactionService.Get(id);
        }
    }
}
