﻿using Microsoft.AspNet.Identity;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/replies")]
    public class ReplyController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            ReplyService replyService = CreateReplyService();
            var replies = replyService.GetCommentReplies();
            return Ok(replies);
        }

        [HttpPost]
        public IHttpActionResult Post(PostReplyToComment reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.ReplyOnComment(reply))
                return InternalServerError();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateReplyService();

            if (!service.DeleteReply(id))
                return InternalServerError();

            return Ok();

        }

        private ReplyService CreateReplyService()
        {
            var authorId = Guid.Parse(User.Identity.GetUserId());
            var replyService = new ReplyService(authorId);
            return replyService;
        }
    }
}
