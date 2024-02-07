using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.UseCases.Actions.GetCurrent;

public class GetCurrentAuctionsUseCase
{
    public Auction Execute()
    {
        return new Auction
        {
            Id = 1,
            Name = "Test",
            Starts = DateTime.Now,
            Ends = DateTime.Now,
        };

    }
}

