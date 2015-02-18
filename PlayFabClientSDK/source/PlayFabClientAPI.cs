using System;
using System.IO;
using System.Threading.Tasks;

using Newtonsoft.Json;

using PlayFab.Internal;
using PlayFab.ClientModels;


namespace PlayFab
{

	
	/// <summary>
	/// APIs which provide the full range of PlayFab features available to the client - authentication, account and data management, inventory, friends, matchmaking, reporting, and platform-specific functionality
	/// </summary>
    public class PlayFabClientAPI
    {
		
		
		/// <summary>
		/// Signs the user in using the Android device identifier, returning a session identifier that can subsequently be used for API calls which require an authenticated user
		/// </summary>
        public static async Task<PlayFabResult<LoginResult>> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest request)
        {
            request.TitleId = PlayFabSettings.TitleId ?? request.TitleId;
			if(request.TitleId == null) throw new Exception ("Must be have PlayFabSettings.TitleId set to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LoginWithAndroidDeviceID", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LoginResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LoginResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LoginResult result = resultData.data;
			AuthKey = result.SessionTicket ?? AuthKey;

			
            return new PlayFabResult<LoginResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Signs the user in using a Facebook access token, returning a session identifier that can subsequently be used for API calls which require an authenticated user
		/// </summary>
        public static async Task<PlayFabResult<LoginResult>> LoginWithFacebookAsync(LoginWithFacebookRequest request)
        {
            request.TitleId = PlayFabSettings.TitleId ?? request.TitleId;
			if(request.TitleId == null) throw new Exception ("Must be have PlayFabSettings.TitleId set to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LoginWithFacebook", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LoginResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LoginResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LoginResult result = resultData.data;
			AuthKey = result.SessionTicket ?? AuthKey;

			
            return new PlayFabResult<LoginResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Signs the user in using an iOS Game Center player identifier, returning a session identifier that can subsequently be used for API calls which require an authenticated user
		/// </summary>
        public static async Task<PlayFabResult<LoginResult>> LoginWithGameCenterAsync(LoginWithGameCenterRequest request)
        {
            request.TitleId = PlayFabSettings.TitleId ?? request.TitleId;
			if(request.TitleId == null) throw new Exception ("Must be have PlayFabSettings.TitleId set to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LoginWithGameCenter", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LoginResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LoginResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LoginResult result = resultData.data;
			AuthKey = result.SessionTicket ?? AuthKey;

			
            return new PlayFabResult<LoginResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Signs the user in using a Google account access token, returning a session identifier that can subsequently be used for API calls which require an authenticated user
		/// </summary>
        public static async Task<PlayFabResult<LoginResult>> LoginWithGoogleAccountAsync(LoginWithGoogleAccountRequest request)
        {
            request.TitleId = PlayFabSettings.TitleId ?? request.TitleId;
			if(request.TitleId == null) throw new Exception ("Must be have PlayFabSettings.TitleId set to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LoginWithGoogleAccount", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LoginResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LoginResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LoginResult result = resultData.data;
			AuthKey = result.SessionTicket ?? AuthKey;

			
            return new PlayFabResult<LoginResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Signs the user in using the vendor-specific iOS device identifier, returning a session identifier that can subsequently be used for API calls which require an authenticated user
		/// </summary>
        public static async Task<PlayFabResult<LoginResult>> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest request)
        {
            request.TitleId = PlayFabSettings.TitleId ?? request.TitleId;
			if(request.TitleId == null) throw new Exception ("Must be have PlayFabSettings.TitleId set to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LoginWithIOSDeviceID", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LoginResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LoginResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LoginResult result = resultData.data;
			AuthKey = result.SessionTicket ?? AuthKey;

			
            return new PlayFabResult<LoginResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Signs the user into the PlayFab account, returning a session identifier that can subsequently be used for API calls which require an authenticated user
		/// </summary>
        public static async Task<PlayFabResult<LoginResult>> LoginWithPlayFabAsync(LoginWithPlayFabRequest request)
        {
            request.TitleId = PlayFabSettings.TitleId ?? request.TitleId;
			if(request.TitleId == null) throw new Exception ("Must be have PlayFabSettings.TitleId set to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LoginWithPlayFab", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LoginResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LoginResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LoginResult result = resultData.data;
			AuthKey = result.SessionTicket ?? AuthKey;

			
            return new PlayFabResult<LoginResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Signs the user in using a Steam authentication ticket, returning a session identifier that can subsequently be used for API calls which require an authenticated user
		/// </summary>
        public static async Task<PlayFabResult<LoginResult>> LoginWithSteamAsync(LoginWithSteamRequest request)
        {
            request.TitleId = PlayFabSettings.TitleId ?? request.TitleId;
			if(request.TitleId == null) throw new Exception ("Must be have PlayFabSettings.TitleId set to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LoginWithSteam", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LoginResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LoginResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LoginResult result = resultData.data;
			AuthKey = result.SessionTicket ?? AuthKey;

			
            return new PlayFabResult<LoginResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Registers a new Playfab user account, returning a session identifier that can subsequently be used for API calls which require an authenticated user
		/// </summary>
        public static async Task<PlayFabResult<RegisterPlayFabUserResult>> RegisterPlayFabUserAsync(RegisterPlayFabUserRequest request)
        {
            request.TitleId = PlayFabSettings.TitleId ?? request.TitleId;
			if(request.TitleId == null) throw new Exception ("Must be have PlayFabSettings.TitleId set to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/RegisterPlayFabUser", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<RegisterPlayFabUserResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<RegisterPlayFabUserResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			RegisterPlayFabUserResult result = resultData.data;
			AuthKey = result.SessionTicket ?? AuthKey;

			
            return new PlayFabResult<RegisterPlayFabUserResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Adds playfab username/password auth to an existing semi-anonymous account created via a 3rd party auth method.
		/// </summary>
        public static async Task<PlayFabResult<AddUsernamePasswordResult>> AddUsernamePasswordAsync(AddUsernamePasswordRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/AddUsernamePassword", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<AddUsernamePasswordResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<AddUsernamePasswordResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			AddUsernamePasswordResult result = resultData.data;
			
			
            return new PlayFabResult<AddUsernamePasswordResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the user's PlayFab account details
		/// </summary>
        public static async Task<PlayFabResult<GetAccountInfoResult>> GetAccountInfoAsync(GetAccountInfoRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetAccountInfo", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetAccountInfoResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetAccountInfoResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetAccountInfoResult result = resultData.data;
			
			
            return new PlayFabResult<GetAccountInfoResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the unique PlayFab identifiers for the given set of Facebook identifiers.
		/// </summary>
        public static async Task<PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetPlayFabIDsFromFacebookIDs", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromFacebookIDsResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetPlayFabIDsFromFacebookIDsResult result = resultData.data;
			
			
            return new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves all requested data for a user in one unified request. By default, this API returns all  data for the locally signed-in user. The input parameters may be used to limit the data retrieved any any subset of the available data, as well as retrieve the available data for a different user. Note that certain data, including inventory, virtual currency balances, and personally identifying information, may only be retrieved for the locally signed-in user. In the example below, a request is made for the account details, virtual currency balances, and specified user data for the locally signed-in user.
		/// </summary>
        public static async Task<PlayFabResult<GetUserCombinedInfoResult>> GetUserCombinedInfoAsync(GetUserCombinedInfoRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetUserCombinedInfo", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetUserCombinedInfoResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetUserCombinedInfoResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetUserCombinedInfoResult result = resultData.data;
			
			
            return new PlayFabResult<GetUserCombinedInfoResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Links the Android device identifier to the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<LinkAndroidDeviceIDResult>> LinkAndroidDeviceIDAsync(LinkAndroidDeviceIDRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LinkAndroidDeviceID", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LinkAndroidDeviceIDResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LinkAndroidDeviceIDResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LinkAndroidDeviceIDResult result = resultData.data;
			
			
            return new PlayFabResult<LinkAndroidDeviceIDResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Links the Facebook account associated with the provided Facebook access token to the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<LinkFacebookAccountResult>> LinkFacebookAccountAsync(LinkFacebookAccountRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LinkFacebookAccount", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LinkFacebookAccountResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LinkFacebookAccountResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LinkFacebookAccountResult result = resultData.data;
			
			
            return new PlayFabResult<LinkFacebookAccountResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Links the Game Center account associated with the provided Game Center ID to the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<LinkGameCenterAccountResult>> LinkGameCenterAccountAsync(LinkGameCenterAccountRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LinkGameCenterAccount", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LinkGameCenterAccountResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LinkGameCenterAccountResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LinkGameCenterAccountResult result = resultData.data;
			
			
            return new PlayFabResult<LinkGameCenterAccountResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Links the vendor-specific iOS device identifier to the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<LinkIOSDeviceIDResult>> LinkIOSDeviceIDAsync(LinkIOSDeviceIDRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LinkIOSDeviceID", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LinkIOSDeviceIDResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LinkIOSDeviceIDResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LinkIOSDeviceIDResult result = resultData.data;
			
			
            return new PlayFabResult<LinkIOSDeviceIDResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Links the Steam account associated with the provided Steam authentication ticket to the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<LinkSteamAccountResult>> LinkSteamAccountAsync(LinkSteamAccountRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LinkSteamAccount", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LinkSteamAccountResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LinkSteamAccountResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LinkSteamAccountResult result = resultData.data;
			
			
            return new PlayFabResult<LinkSteamAccountResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Forces an email to be sent to the registered email address for the user's account, with a link allowing the user to change the password
		/// </summary>
        public static async Task<PlayFabResult<SendAccountRecoveryEmailResult>> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest request)
        {
            
            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/SendAccountRecoveryEmail", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<SendAccountRecoveryEmailResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<SendAccountRecoveryEmailResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			SendAccountRecoveryEmailResult result = resultData.data;
			
			
            return new PlayFabResult<SendAccountRecoveryEmailResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Unlinks the related Android device identifier from the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<UnlinkAndroidDeviceIDResult>> UnlinkAndroidDeviceIDAsync(UnlinkAndroidDeviceIDRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UnlinkAndroidDeviceID", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UnlinkAndroidDeviceIDResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UnlinkAndroidDeviceIDResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UnlinkAndroidDeviceIDResult result = resultData.data;
			
			
            return new PlayFabResult<UnlinkAndroidDeviceIDResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Unlinks the related Facebook account from the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<UnlinkFacebookAccountResult>> UnlinkFacebookAccountAsync(UnlinkFacebookAccountRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UnlinkFacebookAccount", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UnlinkFacebookAccountResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UnlinkFacebookAccountResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UnlinkFacebookAccountResult result = resultData.data;
			
			
            return new PlayFabResult<UnlinkFacebookAccountResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Unlinks the related Game Center account from the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<UnlinkGameCenterAccountResult>> UnlinkGameCenterAccountAsync(UnlinkGameCenterAccountRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UnlinkGameCenterAccount", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UnlinkGameCenterAccountResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UnlinkGameCenterAccountResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UnlinkGameCenterAccountResult result = resultData.data;
			
			
            return new PlayFabResult<UnlinkGameCenterAccountResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Unlinks the related iOS device identifier from the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<UnlinkIOSDeviceIDResult>> UnlinkIOSDeviceIDAsync(UnlinkIOSDeviceIDRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UnlinkIOSDeviceID", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UnlinkIOSDeviceIDResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UnlinkIOSDeviceIDResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UnlinkIOSDeviceIDResult result = resultData.data;
			
			
            return new PlayFabResult<UnlinkIOSDeviceIDResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Unlinks the related Steam account from the user's PlayFab account
		/// </summary>
        public static async Task<PlayFabResult<UnlinkSteamAccountResult>> UnlinkSteamAccountAsync(UnlinkSteamAccountRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UnlinkSteamAccount", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UnlinkSteamAccountResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UnlinkSteamAccountResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UnlinkSteamAccountResult result = resultData.data;
			
			
            return new PlayFabResult<UnlinkSteamAccountResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Updates the local user's email address in PlayFab
		/// </summary>
        public static async Task<PlayFabResult<UpdateEmailAddressResult>> UpdateEmailAddressAsync(UpdateEmailAddressRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UpdateEmailAddress", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UpdateEmailAddressResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UpdateEmailAddressResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UpdateEmailAddressResult result = resultData.data;
			
			
            return new PlayFabResult<UpdateEmailAddressResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Updates the title specific display name for the user
		/// </summary>
        public static async Task<PlayFabResult<UpdateUserTitleDisplayNameResult>> UpdateUserTitleDisplayNameAsync(UpdateUserTitleDisplayNameRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UpdateUserTitleDisplayName", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UpdateUserTitleDisplayNameResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UpdateUserTitleDisplayNameResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UpdateUserTitleDisplayNameResult result = resultData.data;
			
			
            return new PlayFabResult<UpdateUserTitleDisplayNameResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves a list of ranked friends of the current player for the given statistic, starting from the indicated point in the leaderboard
		/// </summary>
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetFriendLeaderboard", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetLeaderboardResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetLeaderboardResult result = resultData.data;
			
			
            return new PlayFabResult<GetLeaderboardResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves a list of ranked users for the given statistic, starting from the indicated point in the leaderboard
		/// </summary>
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetLeaderboardAsync(GetLeaderboardRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetLeaderboard", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetLeaderboardResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetLeaderboardResult result = resultData.data;
			
			
            return new PlayFabResult<GetLeaderboardResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves a list of ranked users for the given statistic, centered on the currently signed-in user
		/// </summary>
        public static async Task<PlayFabResult<GetLeaderboardAroundCurrentUserResult>> GetLeaderboardAroundCurrentUserAsync(GetLeaderboardAroundCurrentUserRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetLeaderboardAroundCurrentUser", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetLeaderboardAroundCurrentUserResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardAroundCurrentUserResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetLeaderboardAroundCurrentUserResult result = resultData.data;
			
			
            return new PlayFabResult<GetLeaderboardAroundCurrentUserResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the title-specific custom data for the user which is readable and writable by the client
		/// </summary>
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetUserData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetUserDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetUserDataResult result = resultData.data;
			
			
            return new PlayFabResult<GetUserDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the publisher-specific custom data for the user which is readable and writable by the client
		/// </summary>
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetUserPublisherData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetUserDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetUserDataResult result = resultData.data;
			
			
            return new PlayFabResult<GetUserDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the publisher-specific custom data for the user which can only be read by the client
		/// </summary>
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetUserPublisherReadOnlyData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetUserDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetUserDataResult result = resultData.data;
			
			
            return new PlayFabResult<GetUserDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the title-specific custom data for the user which can only be read by the client
		/// </summary>
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(GetUserDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetUserReadOnlyData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetUserDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetUserDataResult result = resultData.data;
			
			
            return new PlayFabResult<GetUserDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the details of all title-specific statistics for the user
		/// </summary>
        public static async Task<PlayFabResult<GetUserStatisticsResult>> GetUserStatisticsAsync(GetUserStatisticsRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetUserStatistics", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetUserStatisticsResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetUserStatisticsResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetUserStatisticsResult result = resultData.data;
			
			
            return new PlayFabResult<GetUserStatisticsResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Creates and updates the title-specific custom data for the user which is readable and writable by the client
		/// </summary>
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UpdateUserData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UpdateUserDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UpdateUserDataResult result = resultData.data;
			
			
            return new PlayFabResult<UpdateUserDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Creates and updates the publisher-specific custom data for the user which is readable and writable by the client
		/// </summary>
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UpdateUserPublisherData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UpdateUserDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UpdateUserDataResult result = resultData.data;
			
			
            return new PlayFabResult<UpdateUserDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Updates the values of the specified title-specific statistics for the user
		/// </summary>
        public static async Task<PlayFabResult<UpdateUserStatisticsResult>> UpdateUserStatisticsAsync(UpdateUserStatisticsRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UpdateUserStatistics", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UpdateUserStatisticsResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UpdateUserStatisticsResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UpdateUserStatisticsResult result = resultData.data;
			
			
            return new PlayFabResult<UpdateUserStatisticsResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the specified version of the title's catalog of virtual goods, including all defined properties
		/// </summary>
        public static async Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItemsAsync(GetCatalogItemsRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetCatalogItems", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetCatalogItemsResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetCatalogItemsResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetCatalogItemsResult result = resultData.data;
			
			
            return new PlayFabResult<GetCatalogItemsResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the set of items defined for the specified store, including all prices defined
		/// </summary>
        public static async Task<PlayFabResult<GetStoreItemsResult>> GetStoreItemsAsync(GetStoreItemsRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetStoreItems", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetStoreItemsResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetStoreItemsResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetStoreItemsResult result = resultData.data;
			
			
            return new PlayFabResult<GetStoreItemsResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the key-value store of custom title settings
		/// </summary>
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleDataAsync(GetTitleDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetTitleData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetTitleDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetTitleDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetTitleDataResult result = resultData.data;
			
			
            return new PlayFabResult<GetTitleDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the title news feed, as configured in the developer portal
		/// </summary>
        public static async Task<PlayFabResult<GetTitleNewsResult>> GetTitleNewsAsync(GetTitleNewsRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetTitleNews", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetTitleNewsResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetTitleNewsResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetTitleNewsResult result = resultData.data;
			
			
            return new PlayFabResult<GetTitleNewsResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Increments the user's balance of the specified virtual currency by the stated amount
		/// </summary>
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/AddUserVirtualCurrency", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<ModifyUserVirtualCurrencyResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<ModifyUserVirtualCurrencyResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			ModifyUserVirtualCurrencyResult result = resultData.data;
			
			
            return new PlayFabResult<ModifyUserVirtualCurrencyResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Confirms with the payment provider that the purchase was approved (if applicable) and adjusts inventory and virtual currency balances as appropriate
		/// </summary>
        public static async Task<PlayFabResult<ConfirmPurchaseResult>> ConfirmPurchaseAsync(ConfirmPurchaseRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/ConfirmPurchase", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<ConfirmPurchaseResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<ConfirmPurchaseResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			ConfirmPurchaseResult result = resultData.data;
			
			
            return new PlayFabResult<ConfirmPurchaseResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Consume uses of a consumable item. When all uses are consumed, it will be removed from the player's inventory.
		/// </summary>
        public static async Task<PlayFabResult<ConsumeItemResult>> ConsumeItemAsync(ConsumeItemRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/ConsumeItem", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<ConsumeItemResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<ConsumeItemResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			ConsumeItemResult result = resultData.data;
			
			
            return new PlayFabResult<ConsumeItemResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the user's current inventory of virtual goods
		/// </summary>
        public static async Task<PlayFabResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetUserInventory", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetUserInventoryResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetUserInventoryResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetUserInventoryResult result = resultData.data;
			
			
            return new PlayFabResult<GetUserInventoryResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Selects a payment option for purchase order created via StartPurchase
		/// </summary>
        public static async Task<PlayFabResult<PayForPurchaseResult>> PayForPurchaseAsync(PayForPurchaseRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/PayForPurchase", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<PayForPurchaseResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<PayForPurchaseResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			PayForPurchaseResult result = resultData.data;
			
			
            return new PlayFabResult<PayForPurchaseResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Buys a single item with virtual currency. You must specify both the virtual currency to use to purchase, as well as what the client believes the price to be. This lets the server fail the purchase if the price has changed.
		/// </summary>
        public static async Task<PlayFabResult<PurchaseItemResult>> PurchaseItemAsync(PurchaseItemRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/PurchaseItem", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<PurchaseItemResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<PurchaseItemResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			PurchaseItemResult result = resultData.data;
			
			
            return new PlayFabResult<PurchaseItemResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Adds the virtual goods associated with the coupon to the user's inventory
		/// </summary>
        public static async Task<PlayFabResult<RedeemCouponResult>> RedeemCouponAsync(RedeemCouponRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/RedeemCoupon", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<RedeemCouponResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<RedeemCouponResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			RedeemCouponResult result = resultData.data;
			
			
            return new PlayFabResult<RedeemCouponResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Report a player
		/// </summary>
        public static async Task<PlayFabResult<ReportPlayerClientResult>> ReportPlayerAsync(ReportPlayerClientRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/ReportPlayer", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<ReportPlayerClientResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<ReportPlayerClientResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			ReportPlayerClientResult result = resultData.data;
			
			
            return new PlayFabResult<ReportPlayerClientResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Creates an order for a list of items from the title catalog
		/// </summary>
        public static async Task<PlayFabResult<StartPurchaseResult>> StartPurchaseAsync(StartPurchaseRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/StartPurchase", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<StartPurchaseResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<StartPurchaseResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			StartPurchaseResult result = resultData.data;
			
			
            return new PlayFabResult<StartPurchaseResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Decrements the user's balance of the specified virtual currency by the stated amount
		/// </summary>
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/SubtractUserVirtualCurrency", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<ModifyUserVirtualCurrencyResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<ModifyUserVirtualCurrencyResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			ModifyUserVirtualCurrencyResult result = resultData.data;
			
			
            return new PlayFabResult<ModifyUserVirtualCurrencyResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Unlocks a container item in the user's inventory and consumes a key item of the type indicated by the container item
		/// </summary>
        public static async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerItemAsync(UnlockContainerItemRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UnlockContainerItem", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UnlockContainerItemResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UnlockContainerItemResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UnlockContainerItemResult result = resultData.data;
			
			
            return new PlayFabResult<UnlockContainerItemResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Adds the PlayFab user, based upon a match against a supplied unique identifier, to the friend list of the local user
		/// </summary>
        public static async Task<PlayFabResult<AddFriendResult>> AddFriendAsync(AddFriendRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/AddFriend", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<AddFriendResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<AddFriendResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			AddFriendResult result = resultData.data;
			
			
            return new PlayFabResult<AddFriendResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the current friend list for the local user, constrained to users who have PlayFab accounts
		/// </summary>
        public static async Task<PlayFabResult<GetFriendsListResult>> GetFriendsListAsync(GetFriendsListRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetFriendsList", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetFriendsListResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetFriendsListResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetFriendsListResult result = resultData.data;
			
			
            return new PlayFabResult<GetFriendsListResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Removes a specified user from the friend list of the local user
		/// </summary>
        public static async Task<PlayFabResult<RemoveFriendResult>> RemoveFriendAsync(RemoveFriendRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/RemoveFriend", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<RemoveFriendResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<RemoveFriendResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			RemoveFriendResult result = resultData.data;
			
			
            return new PlayFabResult<RemoveFriendResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Updates the tag list for a specified user in the friend list of the local user
		/// </summary>
        public static async Task<PlayFabResult<SetFriendTagsResult>> SetFriendTagsAsync(SetFriendTagsRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/SetFriendTags", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<SetFriendTagsResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<SetFriendTagsResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			SetFriendTagsResult result = resultData.data;
			
			
            return new PlayFabResult<SetFriendTagsResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Registers the iOS device to receive push notifications
		/// </summary>
        public static async Task<PlayFabResult<RegisterForIOSPushNotificationResult>> RegisterForIOSPushNotificationAsync(RegisterForIOSPushNotificationRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/RegisterForIOSPushNotification", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<RegisterForIOSPushNotificationResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<RegisterForIOSPushNotificationResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			RegisterForIOSPushNotificationResult result = resultData.data;
			
			
            return new PlayFabResult<RegisterForIOSPushNotificationResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Restores all in-app purchases based on the given refresh receipt.
		/// </summary>
        public static async Task<PlayFabResult<RestoreIOSPurchasesResult>> RestoreIOSPurchasesAsync(RestoreIOSPurchasesRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/RestoreIOSPurchases", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<RestoreIOSPurchasesResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<RestoreIOSPurchasesResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			RestoreIOSPurchasesResult result = resultData.data;
			
			
            return new PlayFabResult<RestoreIOSPurchasesResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Validates with the Apple store that the receipt for an iOS in-app purchase is valid and that it matches the purchased catalog item
		/// </summary>
        public static async Task<PlayFabResult<ValidateIOSReceiptResult>> ValidateIOSReceiptAsync(ValidateIOSReceiptRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/ValidateIOSReceipt", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<ValidateIOSReceiptResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<ValidateIOSReceiptResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			ValidateIOSReceiptResult result = resultData.data;
			
			
            return new PlayFabResult<ValidateIOSReceiptResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Get details about all current running game servers matching the given parameters.
		/// </summary>
        public static async Task<PlayFabResult<CurrentGamesResult>> GetCurrentGamesAsync(CurrentGamesRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetCurrentGames", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<CurrentGamesResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<CurrentGamesResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			CurrentGamesResult result = resultData.data;
			
			
            return new PlayFabResult<CurrentGamesResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		///  Get details about the regions hosting game servers matching the given parameters.
		/// </summary>
        public static async Task<PlayFabResult<GameServerRegionsResult>> GetGameServerRegionsAsync(GameServerRegionsRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetGameServerRegions", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GameServerRegionsResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GameServerRegionsResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GameServerRegionsResult result = resultData.data;
			
			
            return new PlayFabResult<GameServerRegionsResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Attempts to locate a game session matching the given parameters. Note that parameters specified in the search are required (they are not weighting factors). If a slot is found in a server instance matching the parameters, the slot will be assigned to that player, removing it from the availabe set. In that case, the information on the game session will be returned, otherwise the Status returned will be GameNotFound. Note that EnableQueue is deprecated at this time.
		/// </summary>
        public static async Task<PlayFabResult<MatchmakeResult>> MatchmakeAsync(MatchmakeRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/Matchmake", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<MatchmakeResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<MatchmakeResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			MatchmakeResult result = resultData.data;
			
			
            return new PlayFabResult<MatchmakeResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Start a new game server with a given configuration, add the current player and return the connection information.
		/// </summary>
        public static async Task<PlayFabResult<StartGameResult>> StartGameAsync(StartGameRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/StartGame", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<StartGameResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<StartGameResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			StartGameResult result = resultData.data;
			
			
            return new PlayFabResult<StartGameResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Registers the Android device to receive push notifications
		/// </summary>
        public static async Task<PlayFabResult<AndroidDevicePushNotificationRegistrationResult>> AndroidDevicePushNotificationRegistrationAsync(AndroidDevicePushNotificationRegistrationRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/AndroidDevicePushNotificationRegistration", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<AndroidDevicePushNotificationRegistrationResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<AndroidDevicePushNotificationRegistrationResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			AndroidDevicePushNotificationRegistrationResult result = resultData.data;
			
			
            return new PlayFabResult<AndroidDevicePushNotificationRegistrationResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Validates a Google Play purchase and gives the corresponding item to the player.
		/// </summary>
        public static async Task<PlayFabResult<ValidateGooglePlayPurchaseResult>> ValidateGooglePlayPurchaseAsync(ValidateGooglePlayPurchaseRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/ValidateGooglePlayPurchase", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<ValidateGooglePlayPurchaseResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<ValidateGooglePlayPurchaseResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			ValidateGooglePlayPurchaseResult result = resultData.data;
			
			
            return new PlayFabResult<ValidateGooglePlayPurchaseResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Logs a custom analytics event
		/// </summary>
        public static async Task<PlayFabResult<LogEventResult>> LogEventAsync(LogEventRequest request)
        {
            
            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/LogEvent", request, null, null);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<LogEventResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<LogEventResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			LogEventResult result = resultData.data;
			
			
            return new PlayFabResult<LogEventResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Adds users to the set of those able to update both the shared data, as well as the set of users in the group. Only users in the group can add new members.
		/// </summary>
        public static async Task<PlayFabResult<AddSharedGroupMembersResult>> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/AddSharedGroupMembers", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<AddSharedGroupMembersResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<AddSharedGroupMembersResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			AddSharedGroupMembersResult result = resultData.data;
			
			
            return new PlayFabResult<AddSharedGroupMembersResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Requests the creation of a shared group object, containing key/value pairs which may be updated by all members of the group. Upon creation, the current user will be the only member of the group.
		/// </summary>
        public static async Task<PlayFabResult<CreateSharedGroupResult>> CreateSharedGroupAsync(CreateSharedGroupRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/CreateSharedGroup", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<CreateSharedGroupResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<CreateSharedGroupResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			CreateSharedGroupResult result = resultData.data;
			
			
            return new PlayFabResult<CreateSharedGroupResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the key-value store of custom publisher settings
		/// </summary>
        public static async Task<PlayFabResult<GetPublisherDataResult>> GetPublisherDataAsync(GetPublisherDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetPublisherData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetPublisherDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetPublisherDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetPublisherDataResult result = resultData.data;
			
			
            return new PlayFabResult<GetPublisherDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves data stored in a shared group object, as well as the list of members in the group. Non-members of the group may use this to retrieve group data, including membership, but they will not receive data for keys marked as private.
		/// </summary>
        public static async Task<PlayFabResult<GetSharedGroupDataResult>> GetSharedGroupDataAsync(GetSharedGroupDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetSharedGroupData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetSharedGroupDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetSharedGroupDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetSharedGroupDataResult result = resultData.data;
			
			
            return new PlayFabResult<GetSharedGroupDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Removes users from the set of those able to update the shared data and the set of users in the group. Only users in the group can remove members. If as a result of the call, zero users remain with access, the group and its associated data will be deleted.
		/// </summary>
        public static async Task<PlayFabResult<RemoveSharedGroupMembersResult>> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/RemoveSharedGroupMembers", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<RemoveSharedGroupMembersResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<RemoveSharedGroupMembersResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			RemoveSharedGroupMembersResult result = resultData.data;
			
			
            return new PlayFabResult<RemoveSharedGroupMembersResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Adds, updates, and removes data keys for a shared group object. If the permission is set to Public, all fields updated or added in this call will be readable by users not in the group. By default, data permissions are set to Private. Regardless of the permission setting, only members of the group can update the data.
		/// </summary>
        public static async Task<PlayFabResult<UpdateSharedGroupDataResult>> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/UpdateSharedGroupData", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<UpdateSharedGroupDataResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<UpdateSharedGroupDataResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			UpdateSharedGroupDataResult result = resultData.data;
			
			
            return new PlayFabResult<UpdateSharedGroupDataResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Uses the supplied OAuth code to refresh the internally cached player PSN auth token
		/// </summary>
        public static async Task<PlayFabResult<EmptyResult>> RefreshPSNAuthTokenAsync(RefreshPSNAuthTokenRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/RefreshPSNAuthToken", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<EmptyResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			EmptyResult result = resultData.data;
			
			
            return new PlayFabResult<EmptyResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Retrieves the title-specific URL for Cloud Script servers. This must be queried once, prior  to making any calls to RunCloudScript.
		/// </summary>
        public static async Task<PlayFabResult<GetCloudScriptUrlResult>> GetCloudScriptUrlAsync(GetCloudScriptUrlRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetURL() + "/Client/GetCloudScriptUrl", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<GetCloudScriptUrlResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<GetCloudScriptUrlResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			GetCloudScriptUrlResult result = resultData.data;
			PlayFabSettings.LogicServerURL = result.Url;

			
            return new PlayFabResult<GetCloudScriptUrlResult>
                {
                    Result = result
                };
        }
		
		/// <summary>
		/// Triggers a particular server action, passing the provided inputs to the hosted Cloud Script. An action in this context is a handler in the JavaScript.
		/// </summary>
        public static async Task<PlayFabResult<RunCloudScriptResult>> RunCloudScriptAsync(RunCloudScriptRequest request)
        {
            if (AuthKey == null) throw new Exception ("Must be logged in to call this method");

            object httpResult = await PlayFabHTTP.DoPost(PlayFabSettings.GetLogicURL() + "/Client/RunCloudScript", request, "X-Authorization", AuthKey);
            if(httpResult is PlayFabError)
            {
                PlayFabError error = (PlayFabError)httpResult;
                if (PlayFabSettings.GlobalErrorHandler != null)
                    PlayFabSettings.GlobalErrorHandler(error);
                return new PlayFabResult<RunCloudScriptResult>
                {
                    Error = error,
                };
            }
            string resultRawJson = (string)httpResult;

            var serializer = JsonSerializer.Create(PlayFabSettings.JsonSettings);
            var resultData = serializer.Deserialize<PlayFabJsonSuccess<RunCloudScriptResult>>(new JsonTextReader(new StringReader(resultRawJson)));
			
			RunCloudScriptResult result = resultData.data;
			
			
            return new PlayFabResult<RunCloudScriptResult>
                {
                    Result = result
                };
        }

        
		private static string AuthKey = null;
		
    }
}