﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KevinBlogApi.Core.Model.Interface
{
    public interface IPostRepository
    {
        Task<bool> AddOrEdit(Post post);

        Task<Post> GetPost(System.Linq.Expressions.Expression<Func<Post, bool>> expression);

        Task<IEnumerable<Post>> ToListAsync();        

        Task<bool> DeletePost(string id);
    }
}
