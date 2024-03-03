using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI;

namespace TestWebAPI
{
    static internal class TestTools
    {
        public static readonly Guid Guid1 = new Guid("11111111-1111-1111-1111-111111111111");

        public static KnowledgeBase GetKnowledgeBase()
        {
            return new KnowledgeBase
            {
                Id = Guid1,
                Name = "Test Knowledge Base"
            };
        }
    }
}
