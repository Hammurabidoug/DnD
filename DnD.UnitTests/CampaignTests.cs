using System;
using System.Threading.Tasks;
using Xunit;

namespace DnD.UnitTests
{
    public class CampaignTests
    {
        [Fact]
        public async Task CreateCampaign()
        {
            var campaignName = Guid.NewGuid().ToString();
            var campaign = await Task.FromResult(new Campaign(campaignName));

            Assert.NotNull(campaign.Name);
        }

        [Fact]
        public async Task NamePropertyIsSetOnCreate()
        {
            var expected = Guid.NewGuid().ToString();
            var campaign = await Task.FromResult(new Campaign(expected));

            var actual = campaign.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FailedTest()
        {
            Assert.True(false);
        }

    }
}
