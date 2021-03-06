﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogoProducao.Controllers
{
    [Route("api/atores")]
    [ApiController]
    public class AtorController : ControllerBase
    {
        public AtorController()
        {
        }   

        [HttpGet]
        [Route("")]
        public ActionResult BuscarAtores()
        {           
            return Ok();
        }

        [HttpPost]
        [Route("")]
        public ActionResult AdicionarAtor()
        {
            return Ok();
        }
    }
}