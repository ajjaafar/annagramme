using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projet_test.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projet_test.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class AnagrammeController :ControllerBase
    {
       
       private readonly IAnagrammeService _anagrammeService;
        public AnagrammeController(IAnagrammeService anagrammeService)
        {
            _anagrammeService = anagrammeService;
        }


        // POST api/<ValuesController>
        [HttpPost]
        public bool Post(string word1, string word2)
        {
            try
            {
                return _anagrammeService.IsAnagramme(word1, word2);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
