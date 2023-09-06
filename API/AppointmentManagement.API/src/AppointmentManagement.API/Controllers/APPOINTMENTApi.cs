/*
 * Swagger Appointment managment - RTM - OpenAPI 3.1
 *
 * This is the OpenAPI 3.0 specification of Appointment managment - RTM.
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

namespace AppointmentManagement.API.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class APPOINTMENTApiController : ControllerBase
    { 
        /// <summary>
        /// Create a new appointment
        /// </summary>
        /// <remarks>Create a new appointment by Id</remarks>
        /// <param name="APPOINTMENT"></param>
        /// <response code="200"></response>
        /// <response code="0"></response>
        [HttpPost]
        [Route("/api/v3/appointments")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("CreateAppointment")]
        public virtual IActionResult CreateAppointment([FromBody]APPOINTMENT APPOINTMENT)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a single appointment
        /// </summary>
        /// <remarks>Delete a single appointment by Id</remarks>
        /// <param name="appointmentID"></param>
        /// <response code="204">Deleted the appointment</response>
        /// <response code="0"></response>
        [HttpDelete]
        [Route("/api/v3/appointments/{AppointmentID}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteAppointment")]
        public virtual IActionResult DeleteAppointment([FromRoute (Name = "AppointmentID")][Required]Object appointmentID)
        {

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a single appointment
        /// </summary>
        /// <remarks>Get a single appointment by Id</remarks>
        /// <param name="appointmentID"></param>
        /// <response code="200"></response>
        /// <response code="0"></response>
        [HttpGet]
        [Route("/api/v3/appointments/{AppointmentID}")]
        [ValidateModelState]
        [SwaggerOperation("GetAppointment")]
        public virtual IActionResult GetAppointment([FromRoute (Name = "AppointmentID")][Required]Object appointmentID)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all appointments
        /// </summary>
        /// <remarks>Get all appointments as JSON</remarks>
        /// <response code="200">Success</response>
        /// <response code="0"></response>
        [HttpGet]
        [Route("/api/v3/appointments")]
        [ValidateModelState]
        [SwaggerOperation("GetAppointments")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "Success")]
        public virtual IActionResult GetAppointments()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Object));
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Replace a single appointment
        /// </summary>
        /// <remarks>Replace a single appointment by Id</remarks>
        /// <param name="appointmentID"></param>
        /// <param name="APPOINTMENT"></param>
        /// <response code="200"></response>
        /// <response code="0"></response>
        [HttpPut]
        [Route("/api/v3/appointments/{AppointmentID}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("ReplaceAppointment")]
        public virtual IActionResult ReplaceAppointment([FromRoute (Name = "AppointmentID")][Required]Object appointmentID, [FromBody]APPOINTMENT APPOINTMENT)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }
    }
}
