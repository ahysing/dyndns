namespace DNSUpdater.Library.Services;

public interface IDnsService
{
    Task<bool> IsKnown(string fqdn);
    Task<UpdateStatus> UpdateAAAARecord(string hostname, string ipv6, int ttl);
    Task<UpdateStatus> UpdateARecord(string fqdn, string ip, int ttl);
}