using NickStrupat;

namespace UnitTests;

public class ZeroTests
{
	[Fact]
	public void HashUInt32_WhenCalledWithZero_DoesNotReturnZero()
	{
		var result = IntHash.Hash(0u);
		Assert.NotEqual(0u, result);
	}

	[Fact]
	public void HashInverseUInt32_WhenCalledWithZero_DoesNotReturnZero()
	{
		var result = IntHash.HashInverse(0u);
		Assert.NotEqual(0u, result);
	}
	
	[Fact]
	public void HashInt32_WhenCalledWithZero_DoesNotReturnZero()
	{
		var result = IntHash.Hash(0);
		Assert.NotEqual(0, result);
	}

	[Fact]
	public void HashInverseInt32_WhenCalledWithZero_DoesNotReturnZero()
	{
		var result = IntHash.HashInverse(0);
		Assert.NotEqual(0, result);
	}
}