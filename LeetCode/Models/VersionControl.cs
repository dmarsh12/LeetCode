using System;
namespace LeetCode.Models
{
	public class VersionControl
	{
		public int BadVersion { get; set; }
		public bool IsBadVersion(int version) => version >= BadVersion;
	}
}

