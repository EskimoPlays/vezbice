namespace RazmestanjeLoptica;

internal static class Randomizer
{
    public static int RSpectrum() => Random.Shared.Next(255);
    public static Color RColor() =>
        Color.FromArgb(RSpectrum(), RSpectrum(), RSpectrum());
}
