# SimHub ACC Dynamic Leaderboards Plugin

This is an ACC specific (at least at the moment) leaderboard plugin providing simple switching between overall/class/relative leaderboards. 

The reason for this plugin is that I found myself creating effectively the same dash leaderboard layout several times for overall leaderboard and then again for class leaderboard and so on. And then again when I decided to change something. With this plugin you need to create only one SimHub dash and assign buttons to swap between different leaderboard types. Also there seem to be some issues with SimHub's ACC leaderboard data, which I set on to fix with this plugin. I provide example dash (named AccDynLeaderboard) which I created for my own use. It's relatively simple one and designed to be used on smartphone.

## Features
- Connect directly to ACC broadcasting server to have most control and try to provide reliable results.
- Provide a way to switch between leaderboard types on a single dash screen with a single click.
    - Also provide gaps and lap deltas that change based on currently selected leaderboard.
- Provide more leaderboard types ([see here](https://kaiusl.github.io/KLPlugins.DynLeaderboards/stable/reference/leaderboards/)).
- Calculate bunch of new properties ([see here](https://kaiusl.github.io/KLPlugins.DynLeaderboards/stable/reference/properties/) or download the plugin as they are also mostly listen under the settings tab).
- More stable calculation of gaps between the cars (no more gap changing by 1s depending if you are in the corner or straights).

## Getting started

* Download the latest release from [OverTake](https://www.overtake.gg/downloads/acc-simhub-dynamic-leaderboards-plugin.50424/) or [here](https://github.com/kaiusl/KLPlugins.Leaderboard/releases)
* To install provided dashboard run "AccDynLeaderboard_v8.simhubdash".
* Copy all the files from folder "SimHub" to the SimHub root
* Open SimHub and enable the plugin
* Check plugin settings for correct "ACC configuration location" under "General settings".  If it's background is green, then we found needed files, if it's red there's something wrong with the location. We need to find the file "...\Documents\Assetto Corsa Competizione\Config\broadcasting.json". It is used to read information needed to connct to ACC broadcasting client.
* If you needed to change the location, restart SimHub.
* Go to "Controls and events" from SimHub sidebar and add mappings for `DynLeaderboardsPlugin.Dynamic.NextLeaderboard` and `DynLeaderboardsPlugin.Dynamic.PreviousLeaderboard` actions. 

	For mapping to controller inputs you need to enable "Controllers input" plugin and to keyboard inputs "Keyboard Input" plugin.
    
* Now the AccDynLeaderboard dash should work.
* For best experience start SimHub before joining the session, but it should work other way too.
 
## More information

Head over to the [docs](https://kaiusl.github.io/KLPlugins.DynLeaderboards/stable/). It describes all available options, [properties](https://kaiusl.github.io/KLPlugins.DynLeaderboards/stable/reference/properties/), [how to use](https://kaiusl.github.io/KLPlugins.DynLeaderboards/stable/user_guide/getting_started/), [configure](https://kaiusl.github.io/KLPlugins.DynLeaderboards/stable/user_guide/config/) and [troubleshoot known issues](https://kaiusl.github.io/KLPlugins.DynLeaderboards/stable/user_guide/troubleshooting/).

### SimHub and ACC version

Last tested on ACC v1.9.6 and SimHub v9.1.22. Since v1.3.0 this plugin needs at least SimHub v8.3.0 to work.
