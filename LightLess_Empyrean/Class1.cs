using RimWorld;
using RimWorld.Planet;

namespace LightLess_Empyrean;

public class BiomeWorker_LightlessEmpyrean : BiomeWorker
{
	public override float GetScore(Tile tile, int tileID)
	{
		if (tile.WaterCovered)
		{
			return -100f;
		}
		if (tile.temperature < -15f || tile.temperature > 20f)
		{
			return 0f;
		}
		if (tile.rainfall < 1300 || tile.rainfall > 1500)
		{
			return 0f;
		}
		return 15f + (tile.temperature - 6f) + (tile.rainfall - 570) / 180f;
	}
}