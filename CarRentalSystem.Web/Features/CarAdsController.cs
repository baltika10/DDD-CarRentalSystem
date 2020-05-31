using CarRentalSystem.Application.Contracts;
using CarRentalSystem.Domain.Models.CarAds;
using CarRentalSystem.Domain.Models.Dealers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class CarAdsController : ControllerBase
{
    private readonly IRepository<CarAd> carAds;
    public CarAdsController(IRepository<CarAd> carAds) => this.carAds = carAds;

    [HttpGet]
    public IEnumerable<CarAd> Get() => this.carAds
        .All()
        .Where(c => c.IsAvailable);

    //private static readonly Dealer Dealer = new Dealer("Dealer", "+4564564565");
    //[HttpGet]
    //public IEnumerable<CarAd> Get() => Dealer.CarAds.Where(c => c.IsAvailable);
}