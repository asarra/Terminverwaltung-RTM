/*
 * Swagger Appointment managment - RTM - OpenAPI 3.1
 *
 * This is the OpenAPI 3.1 specification of Appointment managment - RTM.
 *
 * The version of the OpenAPI document: 0.1
 * Contact: mehmet-ali.asar@protonmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using AppointmentManagement.API.Attributes;
using AppointmentManagement.API.Models;
using AppointmentManagement.API.Attributes;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentManagement.API.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class CONTACTApiController : ControllerBase
    {


        /// <summary>
        /// Create a new contact
        /// </summary>
        /// <remarks>Create a new contact by Id</remarks>
        /// <param name="CONTACT"></param>
        /// <response code="200"></response>
        /// <response code="0"></response>
        [HttpPost]
        [Route("/api/v3/contacts")]
        //[Authorize(Policy = "api_key")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("CreateContact")]
        public virtual IActionResult CreateContact([FromBody]CONTACT CONTACT)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a single contact
        /// </summary>
        /// <remarks>Delete a single contact by Id</remarks>
        /// <param name="contactID"></param>
        /// <response code="204">Deleted the contact</response>
        /// <response code="0"></response>
        [HttpDelete]
        [Route("/api/v3/contacts/{ContactID}")]
        //[Authorize(Policy = "api_key")]
        [ValidateModelState]
        [SwaggerOperation("DeleteContact")]
        public virtual IActionResult DeleteContact([FromRoute (Name = "ContactID")][Required]Object contactID)
        {

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a single contact
        /// </summary>
        /// <remarks>Get a single contact by Id</remarks>
        /// <param name="contactID"></param>
        /// <response code="200"></response>
        /// <response code="0"></response>
        [HttpGet]
        [Route("/api/v3/contacts/{ContactID}")]
        [ValidateModelState]
        [SwaggerOperation("GetContact")]
        public virtual IActionResult GetContact([FromRoute (Name = "ContactID")][Required]Object contactID)
        {

            string apiKey = HttpContext.RequestServices.GetService<IConfiguration>().GetValue<string>("X-API-Key");
            if (HttpContext.Request.Headers["X-API-Key"] == apiKey) return Ok("OK! :)");
            else return Unauthorized();

        }


        /// <summary>
        /// Get all contacts
        /// </summary>
        /// <remarks>Get all contacts as JSON</remarks>
        /// <response code="200">Success</response>
        /// <response code="0"></response>
        [HttpGet]
        [Route("/api/v3/contacts")]
        //[Authorize(Policy = "api_key")]
        [ValidateModelState]
        [SwaggerOperation("GetContacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "Success")]
        public virtual IActionResult GetContacts()
        {



            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            



            string apiKey = HttpContext.RequestServices.GetService<IConfiguration>().GetValue<string>("X-API-Key");
            if (HttpContext.Request.Headers["X-API-Key"] == apiKey) return new ObjectResult(example);
            else return Unauthorized();
        }

        /// <summary>
        /// Replace a single contact
        /// </summary>
        /// <remarks>Replace a single contact by Id</remarks>
        /// <param name="contactID"></param>
        /// <param name="CONTACT"></param>
        /// <response code="200"></response>
        /// <response code="0"></response>
        [HttpPut]
        [Route("/api/v3/contacts/{ContactID}")]
        //[Authorize(Policy = "api_key")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("ReplaceContact")]
        public virtual IActionResult ReplaceContact([FromRoute (Name = "ContactID")][Required]Object contactID, [FromBody]CONTACT CONTACT)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            string apiKey = HttpContext.RequestServices.GetService<IConfiguration>().GetValue<string>("X-API-Key");
            if (HttpContext.Request.Headers["X-API-Key"] == apiKey) return Ok("OK! :)");
            else return Unauthorized();
        }
    }
}
