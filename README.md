﻿# CodeHelper.API.YouTube
CodeHelper.API.YouTube is a lightweight and simple .NET Wrapper to let you access the YouTube Search API
Search for Videos, Channels, playlists, Movies, 3D Videos, ...

		
## Question?
* Frederik van Lierde <https://twitter.com/@frederik_vl/>
* LinkedIN <https://www.linkedin.com/company/codehelper-dotnet/>
* YouTube  API: <https://developers.google.com/youtube/v3/docs>
* GitHub <https://github.com/frederikvanlierde/CodeHelper.API.YouTube>
* NuGet <https://www.nuget.org/packages/CodeHelper.API.YouTube>
* Wiki + Code Examples <https://github.com/frederikvanlierde/CodeHelper.API.YouTube/wiki>


## Version
* 1.0.0 : GetVideoCategories + Search


## Methods
* GetVideoCategoriesList(string regionCode="", string language= "en_US", string categoriesIDS = "") : Returns a list of categories that can be associated with YouTube videos.
* Search(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions searchOptions = null) : Search Videos, Playlist of channels
* SearchVideos(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions searchOptions = null) : Search videos only
* SearchChannels(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null) : Search channels only
* SearchPlayLists(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null) : Search playlists only
* SearchBroadcastEvents(string searchQuery, string eventType = EventyTypes.Completed, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOption = null) : Search BroadcastEvents only 
* SearchLiveEvents(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOption = null) : Returns a collection of broadcast events that are currentl are active/live
* SearchUpcomingEvents(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOption = null) : Returns a collection of upcoming broadcast events
* Search3DVideos(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null) : Search for 3d videos only
* SearchCreativeCommonVideos(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null) : Returns a collection of Videos hat have a Creative Commons license. 
* SearchMovies(string searchQuery, string searchOrder = SearchOrderTpes.Relevance, SearchOptions? searchOptions = null) : Returns a collection of Movies


## Use of Code	
 ```csharp
using CodeHelper.API.YouTube;

YouTubeHelper _helper = new() {APIKEY= "{YOURAPIKEY}" };
var _categories = await _helper._helper.GetVideoCategoriesList("US");

var _videos = await _helper.SearchVideos("API development");
var _channels = await _helper.SearchChannels("Yachting");
var _broadcastingNow = await _helper.SearchLiveEvents("foorball");
var _upcomingEvents = await _helper.SearchUpcomingEvents("F1");
```


## Authentication
YouTube API uses ApiLey and you need to get your **APIKEYS** which you can find via  **My Apps page** <https://console.cloud.google.com/apis/credentials>


## Usage
* Free Plan, but YouTube has quotas in place
