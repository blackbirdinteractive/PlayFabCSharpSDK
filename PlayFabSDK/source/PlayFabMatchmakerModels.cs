using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PlayFab.MatchmakerModels
{
	
	
	
	public class AuthUserRequest
	{
		
		
		/// <summary>
		/// Session Ticket provided by the client
		/// </summary>
		public string AuthorizationTicket { get; set;}
		
		
	}
	
	
	
	public class AuthUserResponse
	{
		
		
		/// <summary>
		/// boolean indicating if the user has been authorized to use the external match-making service
		/// </summary>
		public bool Authorized { get; set;}
		
		/// <summary>
		/// PlayFab unique identifier of the account that has been authorized
		/// </summary>
		public string PlayFabId { get; set;}
		
		
	}
	
	
	
	/// <summary>
	/// A unique instance of an item in a user's inventory
	/// </summary>
	public class ItemInstance : IComparable<ItemInstance>
	{
		
		
		/// <summary>
		/// unique identifier for the inventory item, as defined in the catalog
		/// </summary>
		public string ItemId { get; set;}
		
		/// <summary>
		/// unique item identifier for this specific instance of the item
		/// </summary>
		public string ItemInstanceId { get; set;}
		
		/// <summary>
		/// class name for the inventory item, as defined in the catalog
		/// </summary>
		public string ItemClass { get; set;}
		
		/// <summary>
		/// timestamp for when this instance was purchased
		/// </summary>
		public DateTime? PurchaseDate { get; set;}
		
		/// <summary>
		/// timestamp for when this instance will expire
		/// </summary>
		public DateTime? Expiration { get; set;}
		
		/// <summary>
		/// total number of remaining uses, if this is a consumable item
		/// </summary>
		public int? RemainingUses { get; set;}
		
		/// <summary>
		/// game specific comment associated with this instance when it was added to the user inventory
		/// </summary>
		public string Annotation { get; set;}
		
		/// <summary>
		/// catalog version for the inventory item, when this instance was created
		/// </summary>
		public string CatalogVersion { get; set;}
		
		/// <summary>
		/// unique identifier for the parent inventory item, as defined in the catalog, for object which were added from a bundle or container
		/// </summary>
		public string BundleParent { get; set;}
		
		
		public int CompareTo(ItemInstance other)
        {
            if (other == null || other.ItemInstanceId == null) return 1;
            if (ItemInstanceId == null) return -1;
            return ItemInstanceId.CompareTo(other.ItemInstanceId);
        }
		
	}
	
	
	
	public class PlayerJoinedRequest
	{
		
		
		/// <summary>
		/// unique identifier of the Game Server Instance the user is joining
		/// </summary>
		public string LobbyId { get; set;}
		
		/// <summary>
		/// PlayFab unique identifier for the user joining
		/// </summary>
		public string PlayFabId { get; set;}
		
		
	}
	
	
	
	public class PlayerJoinedResponse
	{
		
		
		
	}
	
	
	
	public class PlayerLeftRequest
	{
		
		
		/// <summary>
		/// unique identifier of the Game Server Instance the user is leaving
		/// </summary>
		public string LobbyId { get; set;}
		
		/// <summary>
		/// PlayFab unique identifier for the user leaving
		/// </summary>
		public string PlayFabId { get; set;}
		
		
	}
	
	
	
	public class PlayerLeftResponse
	{
		
		
		
	}
	
	
	
	public enum Region
	{
		USCentral,
		USEast,
		EUWest,
		Singapore,
		Japan,
		Brazil,
		Australia
	}
	
	
	
	public class StartGameRequest
	{
		
		
		/// <summary>
		/// unique identifier of the previously uploaded build executable which is to be started
		/// </summary>
		public string Build { get; set;}
		
		/// <summary>
		/// region with which to associate the server, for filtering
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public Region Region { get; set;}
		
		/// <summary>
		/// game mode for this Game Server Instance
		/// </summary>
		public string GameMode { get; set;}
		
		/// <summary>
		/// custom command line argument when starting game server process
		/// </summary>
		public string CustomCommandLineData { get; set;}
		
		/// <summary>
		/// http endpoint URL for receiving game status events, if using an external matchmaker. When the game ends, PlayFab will make a POST request to this URL with the X-SecretKey header set to the value of the game's secret and an application/json body of { "EventName": "game_ended", "GameID": "<gameid>" }
		/// </summary>
		public string ExternalMatchmakerEventEndpoint { get; set;}
		
		
	}
	
	
	
	public class StartGameResponse
	{
		
		
		/// <summary>
		/// unique identifier for the lobby in the new Game Server Instance
		/// </summary>
		public string GameID { get; set;}
		
		/// <summary>
		/// IP address of the new Game Server Instance
		/// </summary>
		public string ServerHostname { get; set;}
		
		/// <summary>
		/// port number for communication with the Game Server Instance
		/// </summary>
		public uint ServerPort { get; set;}
		
		
	}
	
	
	
	public class UserInfoRequest
	{
		
		
		/// <summary>
		/// PlayFab unique identifier of the user whose information is being requested
		/// </summary>
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// minimum catalog version for which data is requested (filters the results to only contain inventory items which have a catalog version of this or higher)
		/// </summary>
		public int MinCatalogVersion { get; set;}
		
		
	}
	
	
	
	public class UserInfoResponse
	{
		
		
		/// <summary>
		/// PlayFab unique identifier of the user whose information was requested
		/// </summary>
		public string PlayFabId { get; set;}
		
		/// <summary>
		/// PlayFab unique user name
		/// </summary>
		public string Username { get; set;}
		
		/// <summary>
		/// title specific display name, if set
		/// </summary>
		public string TitleDisplayName { get; set;}
		
		/// <summary>
		/// array of inventory items in the user's current inventory
		/// </summary>
		[Unordered(SortProperty="ItemInstanceId")]
		public List<ItemInstance> Inventory { get; set;}
		
		/// <summary>
		/// array of virtual currency balance(s) belonging to the user
		/// </summary>
		public Dictionary<string,int> VirtualCurrency { get; set;}
		
		/// <summary>
		/// boolean indicating whether the user is a developer
		/// </summary>
		public bool IsDeveloper { get; set;}
		
		/// <summary>
		/// Steam unique identifier, if the user has an associated Steam account
		/// </summary>
		public string SteamId { get; set;}
		
		
	}
	
}