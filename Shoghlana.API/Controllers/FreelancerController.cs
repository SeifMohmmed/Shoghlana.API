﻿using Microsoft.AspNetCore.Mvc;
using Shoghlana.API.Response;
using Shoghlana.API.Services.Interfaces;
using Shoghlana.Application.DTOs;

namespace Shoghlana.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FreelancerController : ControllerBase
{
    private readonly IFreelancerService _freelancerService;

    public FreelancerController(IFreelancerService freelancerService)
    {
        _freelancerService = freelancerService;
    }


    [HttpGet]
    public ActionResult<GeneralResponse> GetAll()
    {
        return _freelancerService.GetAll();
    }


    [HttpGet("{id:int}")]
    public ActionResult<GeneralResponse> GetById(int id)
    {
        return _freelancerService.GetById(id);
    }


    [HttpPost]
    public async Task<ActionResult<GeneralResponse>> AddFreelancer([FromForm] AddFreelancerDTO addFreelancerDTO)
    {
        if (!ModelState.IsValid)
        {
            return new GeneralResponse()
            {
                IsSuccess = false,
                Status = 400,
                Data = ModelState,
                Message = "Invalid Data!"
            };
        }

        return await _freelancerService.AddAsync(addFreelancerDTO);
    }


    [HttpPut("{id:int}")]
    public async Task<ActionResult<GeneralResponse>> UpdateAsync(int id, [FromForm] AddFreelancerDTO addFreelancerDTO)
    {
        if (!ModelState.IsValid)
        {
            return new GeneralResponse()
            {
                IsSuccess = false,
                Status = 400,
                Data = ModelState,
                Message = "Invalid Data!"
            };
        }

        return await _freelancerService.UpdateAsync(id, addFreelancerDTO);

    }


    [HttpDelete("{id:int}")]
    public ActionResult<GeneralResponse> Delete(int id)
    {
        return _freelancerService.Delete(id);
    }


    [HttpGet("Notification/{freelancerId:int}")]
    public ActionResult<GeneralResponse> GetNotificationByFreelancerId(int freelancerId)
    {
        return
            _freelancerService.GetNotificationByFreelancerId(freelancerId);
    }


}
