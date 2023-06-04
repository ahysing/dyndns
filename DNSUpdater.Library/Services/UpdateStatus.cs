namespace DNSUpdater.Library.Services
{
    public enum UpdateStatus
    {
        good,
        nochg,
        nohost,
        notfqdn,
        badauth,
        othererr
    }
}