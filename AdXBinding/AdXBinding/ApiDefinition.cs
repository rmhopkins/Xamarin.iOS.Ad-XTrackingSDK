using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using StoreKit;

namespace AdXBinding
{
	// @interface AdXTracking : NSObject <NSXMLParserDelegate, UIWebViewDelegate>
	[BaseType (typeof (NSObject))]
	interface AdXTracking {

		// @property (retain, nonatomic) NSString * URLScheme;
		[Export ("URLScheme", ArgumentSemantic.Retain)]
		string URLScheme { get; set; }

		// @property (retain, nonatomic) NSString * ClientId;
		[Export ("ClientId", ArgumentSemantic.Retain)]
		string ClientId { get; set; }

		// @property (retain, nonatomic) NSString * AppleId;
		[Export ("AppleId", ArgumentSemantic.Retain)]
		string AppleId { get; set; }

		// @property (retain, nonatomic) NSString * BundleID;
		[Export ("BundleID", ArgumentSemantic.Retain)]
		string BundleID { get; set; }

		// @property (retain, nonatomic) NSString * CountryCode;
		[Export ("CountryCode", ArgumentSemantic.Retain)]
		string CountryCode { get; set; }

		// @property (retain, nonatomic) NSString * UCDMID;
		[Export ("UCDMID", ArgumentSemantic.Retain)]
		string UCDMID { get; set; }

		// @property (retain, nonatomic) NSString * ADXAppKey;
		[Export ("ADXAppKey", ArgumentSemantic.Retain)]
		string ADXAppKey { get; set; }

		// @property (nonatomic) BOOL Is_upgrade;
		[Export ("Is_upgrade")]
		bool Is_upgrade { get; set; }

		// -(void)sendEvent:(NSString *)event withData:(NSString *)data;
		[Export ("sendEvent:withData:")]
		void SendEvent (string _event, string data);

		// -(void)sendEvent:(NSString *)event withData:(NSString *)data andCurrency:(NSString *)currency;
		[Export ("sendEvent:withData:andCurrency:")]
		void SendEvent (string _event, string data, string currency);

		// -(void)sendEvent:(NSString *)event withData:(NSString *)data andCurrency:(NSString *)currency andCustomData:(NSString *)custom;
		[Export ("sendEvent:withData:andCurrency:andCustomData:")]
		void SendEvent (string _event, string data, string currency, string custom);

		// -(void)setEventParameter:(NSInteger)key withValue:(id)value;
		[Export ("setEventParameter:withValue:")]
		void SetEventParameter (nint key, NSObject value);

		// -(void)setEventParameterOfName:(NSString *)name withValue:(id)value;
		[Export ("setEventParameterOfName:withValue:")]
		void SetEventParameterOfName (string name, NSObject value);

		// -(void)startNewEvent;
		[Export ("startNewEvent")]
		void StartNewEvent ();

		// -(void)addProductToList:(NSString *)product;
		[Export ("addProductToList:")]
		void AddProductToList (string product);

		// -(void)addProductToList:(NSString *)product ofPrice:(float)price forQuantity:(int)quantity;
		[Export ("addProductToList:ofPrice:forQuantity:")]
		void AddProductToList (string product, float price, int quantity);

		// -(void)sendExtendedEvent:(NSInteger)key;
		[Export ("sendExtendedEvent:")]
		void SendExtendedEvent (nint key);

		// -(void)sendExtendedEventOfName:(NSString *)name;
		[Export ("sendExtendedEventOfName:")]
		void SendExtendedEventOfName (string name);

		// -(void)sendAndValidateSaleEvent:(SKPaymentTransaction *)transaction withValue:(NSString *)data andCurrency:(NSString *)currency andCustomData:(NSString *)custom;
		[Export ("sendAndValidateSaleEvent:withValue:andCurrency:andCustomData:")]
		void SendAndValidateSaleEvent (SKPaymentTransaction transaction, string data, string currency, string custom);

		// -(void)reportAppEventToAdX:(NSArray *)eventAndDataReference;
		[Export ("reportAppEventToAdX:")]
		void ReportAppEventToAdX (NSObject [] eventAndDataReference);

		// -(void)reportAppOpen;
		[Export ("reportAppOpen")]
		void ReportAppOpen ();

		// -(BOOL)handleOpenURL:(NSURL *)url;
		[Export ("handleOpenURL:")]
		bool HandleOpenURL (NSUrl url);

		// -(BOOL)parseResponse:(NSData *)data;
		[Export ("parseResponse:")]
		bool ParseResponse (NSData data);

		// -(BOOL)recentSwish;
		[Export ("recentSwish")]
		bool RecentSwish ();

		// -(NSString *)odin1;
		[Export ("odin1")]
		string Odin1 ();

		// -(NSString *)macAddress;
		[Export ("macAddress")]
		string MacAddress ();

		// -(void)isUpgrade:(BOOL)isUpgrade;
		[Export ("isUpgrade:")]
		void IsUpgrade (bool isUpgrade);

		// -(NSString *)getReferral;
		[Export ("getReferral")]
		string GetReferral ();

		// -(NSString *)getDLReferral;
		[Export ("getDLReferral")]
		string GetDLReferral ();

		// -(NSString *)getAdXDeviceIDForEvents;
		[Export ("getAdXDeviceIDForEvents")]
		string GetAdXDeviceIDForEvents ();

		// -(int)isFirstInstall;
		[Export ("isFirstInstall")]
		int IsFirstInstall ();

		// -(NSString *)getTransactionID;
		[Export ("getTransactionID")]
		string GetTransactionID ();

		// -(void)useQAServerUntilYear:(int)year month:(int)month day:(int)day;
		[Export ("useQAServerUntilYear:month:day:")]
		void UseQAServerUntilYear (int year, int month, int day);

		// -(void)sendRequestToAdX:(NSURLRequest *)request withNotificationWhenDone:(_Bool)notify;
		[Export ("sendRequestToAdX:withNotificationWhenDone:")]
		void SendRequestToAdX (NSUrlRequest request, bool notify);
	}

}

