using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BTCPayServer.Plugins.Strike;

/// <summary>
/// This class is a holder of Strike Lightning Clients by TenantId
/// </summary>
public class StrikeLightningClientFactory
{
	private Dictionary<string, StrikeLightningClient> _clients { get; } = new();
	public StrikeLightningClient? GetClient(string tenantId)
	{
		if (_clients.TryGetValue(tenantId, out var client))
		{
			return client;
		}
		return null;
	}
	
	public void AddOrUpdateClient(string tenantId, StrikeLightningClient client)
	{
		_clients[tenantId] = client;
	}

	public string ComputeTenantId(string connectionString)
	{
		var sb = new StringBuilder();
		using (var hash = SHA256.Create())
		{
			var enc = Encoding.UTF8;
			var result = hash.ComputeHash(enc.GetBytes(connectionString));

			foreach (var b in result)
				sb.Append(b.ToString("x2"));
		}

		return sb.ToString();
	}
}
