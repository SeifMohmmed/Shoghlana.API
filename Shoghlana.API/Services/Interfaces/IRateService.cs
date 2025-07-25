﻿using Microsoft.AspNetCore.Mvc;
using Shoghlana.API.Response;
using Shoghlana.Application.DTOs;
using Shoghlana.Domain.Entities;

namespace Shoghlana.API.Services.Interfaces;

public interface IRateService : IGenericService<Rate>
{
    public ActionResult<GeneralResponse> GetAll();

    public ActionResult<GeneralResponse> GetById(int id);

    public Task<ActionResult<GeneralResponse>> CreateRateAsync(RateDTO rateDTO);

    public Task<ActionResult<GeneralResponse>> UpdateRateAsync(int id, RateDTO rateDTO);

    public ActionResult<GeneralResponse> DeleteRate(int id);

}
