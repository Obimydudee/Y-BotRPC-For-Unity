using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;
using UnityEngine.SceneManagement;

public class DiscordController : MonoBehaviour
{
	public Discord.Discord discord;

    void Start()
    {
        discord = new Discord.Discord(826534089896624169, (System.UInt64)Discord.CreateFlags.Default);
		var activityManager = discord.GetActivityManager();
		var activity = new Discord.Activity {
			Details = "🅱️rrrrrrr powered by Unity",	// the first row of text in the rpc
			State = "C# Pain",		// i feel ya mate...Wait.. i made this code ;w;
			Assets = {
				LargeImage = "image",
			}
		};
		activityManager.UpdateActivity(activity, (res) => {
			if (res == Discord.Result.Ok)
				Debug.Log("Discord status set!");
			else
				Debug.LogError("Discord status Fuken Failed!");
		});
		void updateDRPC()
		{
			Debug.Log("Updating Everything");
		}
    }


    void Update()
    {
        discord.RunCallbacks();
    }
}
