﻿//
//  Copyright 2022  Copyright Soluciones Modernas 10x
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dev10x.AspnetCore.Commons.Api.Exceptions;
using Dev10x.BasicTaxonomy.Dtos;
using Dev10x.BasicTaxonomy.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Dev10x.BasicTaxonomy.Controllers
{
    /// <summary>
    /// Controller for the Families operations
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class FamiliesController : ControllerBase
    {
        private readonly FamilyService _familyService;

        /// <summary>
        /// Constructor for service injection
        /// </summary>
        /// <param name="familyService"></param>
        public FamiliesController(FamilyService familyService)
        {
            _familyService = familyService;
        }

        /// <summary>
        /// Return all Family data or 404 error if dont have any
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        public ActionResult<List<FamilyDto>> Get()
        {
            return Ok(_familyService.FindAll());
        }

        /// <summary>
        /// Create new Family 
        /// </summary>
        /// <param name="familyName"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces("application/json")]
        [Consumes("application/json")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        public ActionResult Post(
            [StringLength(50, MinimumLength =3)]
            string familyName
            )
        {
            _familyService.Save(familyName);
            return StatusCode(StatusCodes.Status201Created);
        }

    }
}

