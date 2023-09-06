using Respawn;
using Respawn.Graph;

namespace Requirements.IntegrationTests.Setup
{
    public static class DatabaseSetup
    {
        private static async Task<Respawner> CreateConnection(string connectionString)
        {
            return await Respawner.CreateAsync(connectionString, new RespawnerOptions
            {
                TablesToIgnore = new Table[]
                {
                    "VersionInfo"
                },
            });
        }

        public static async Task Reset(string connection)
        {
            var respawner = await CreateConnection(connection);
            await respawner.ResetAsync(connection);
        }
    }
}
