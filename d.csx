#r "tcp-test.dll"
 
//var folder = @"C:\Users\Rong\Pictures\";
var folder = @"\\RASPBERRYPI\Storage\迅雷下载\downloads";
//var folder = @"C:\Users\tony\Desktop\C#\Playground\";
var cookie = "HABOWEBUID=097bd64def9c4b55412eedbfe9067907; Hm_lvt_be94a17b28798d3dc61eb511641cdd9a=1455522580; referfrom=VIP_3591; risk_tokenid=sohjc0arqqichmz71455616705653; isvip=1; usrname=; upgrade=; order=232374220; jumpkey=96633868A5EBAF7D7C795F600C73F695CEC5EA740075A7B8A93299F6F42EC9072F77A491CA1EB94DD5C8F0192B45EB4AE30027EF32FDE51918CF592B3CABFEE69ABE20E5762A556A453FE3E81FECC9C4A3226518D736E478C95A0184493EE8FF8B82ADFC121ACA5718EC76ED5765C4FE; sessionid=12C1CD35C3E08A938B909DEE51FC85F4F0D0760302C9A6D18480F51AD8770FD243ACF691E5E8F4249742E9D1A08E54C6F1A9984C73A3C94E4FE27C083D746F30; score=0; usernick=0929zhurong; logintype=0; state=0; usertype=0; usernewno=473798247; userid=551334162; shapsw=*; deviceid=wdi10.ea59e51005eca554df66915ec9d0ade1ea7b5a13d405b6315023604e0d053919; _x_a_=12C1CD35C3E08A938B909DEE51FC85F4F0D0760302C9A6D18480F51AD8770FD243ACF691E5E8F4249742E9D1A08E54C6F1A9984C73A3C94E4FE27C083D746F30; _x_t_=1_1; vip_isvip=1; vip_level=1; vip_paytype=4; user_type=1; vip_expiredate=2016-03-17; dl_enable=1; dl_size=2097153; dl_num=143; user_task_time=0.75552701950073; rw_list_open=1; queryTime=1; __xltjbr=1455616739982; _xltj=34a1455616788328b10c22a1455523359761b1c; _s34=1455823260948b1455616788328b2bhttp%3A//dynamic.cloud.vip.xunlei.com/user_task%3Fuserid%3D551334162%26st%3D4; dl_expire=365; default_version=1.0; gdriveid=25A4233F9F85C63636FF74AE7BB74914; task_nowclick=1247652398177024; lx_nf_all=page_check_all%3Dcommtask%26class_check%3D0%26page_check%3Dcommtask%26fl_page_id%3D0%26class_check_new%3D0%26set_tab_status%3D4; bg_opentime=";
var items = new List<string>();
items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=GEY5fDSpe7yf8Hsbdq91pIKKgNjb71f5AAAAADPjLH2FvtcXsuePiyMQs3GRwlSB&mid=666&threshold=150&tid=AB9397D75385294388F46C427AC7CD6D&srcid=4&verno=1&g=33E32C7D85BED717B2E78F8B2310B37191C25481&scn=c16&i=9B5458565AD6B5E66273F92A17009EA4D6AD1C6C&t=6&ui=551334162&ti=1249932647537472&s=4183289819&m=0&n=013559817F4D61727408508A7F323031354100D467307020572473C91B4C2078325705C41E43332D4A387ACA326B760000&ih=9B5458565AD6B5E66273F92A17009EA4D6AD1C6C&fi=1&pi=1249932647471872&ff=0&co=98CEFD00AE6DFEE6DDD29B83D860D541&cm=1&pk=lixian&ak=1:0:1:3&e=1463470394&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=C2290408BE045A87554FD7DB99F5DC8D");
//items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=qhfpupCO+TIS5zEcB9o+mCJxmedmAlsUAAAAAEdAji01KTZL5AB1hm0bI4HH4T7M&mid=666&threshold=150&tid=6C1071E0B613AF839E281C1707D60948&srcid=4&verno=1&g=47408E2D3529364BE40075866D1B2381C7E13ECC&scn=c6&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309995498304&s=341508710&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A3031204141638D3C6B6C6520085FC40B696D65203A00D46730705D203A59CA6D36355D2E0C5A925F00000000&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=9&pi=1251309994842880&ff=0&co=F4805955FE50ADD17AE6545B138E0E4D&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=29652051D5C5BAB29B833426000EAC1B");
//items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=yPvUaq9t5ksX80Fd1a3JBXtrXF79RbwQAAAAABS75XEvEDP/eJeZuB87bUdu8TKe&mid=666&threshold=150&tid=32A0FB1ACD4F055BD7F237972CA4FD23&srcid=4&verno=1&g=14BBE5712F1033FF789799B81F3B6D476EF1329E&scn=c13&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309995432768&s=280774141&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A3032204D0E4390266E6967681511B62A6E205B315109D42F5D205B684F03D26A5D2E6D6B1731E45F00000000&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=8&pi=1251309994842880&ff=0&co=F46274A36E6A53030852A617DBC57657&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=824D0A94390F1CF6EF2C63B43D7DC841");
items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=28JlbgskWaFjzV4xVXF+w727VXOw7oUPAAAAAH4d/XmwYdbsfRFchzvkzPW01Q1c&mid=666&threshold=150&tid=53C5E61419C7A53D4107694BA9962B9C&srcid=4&verno=1&g=7E1DFD79B061D6EC7D115C873BE4CCF5B4D50D5C&scn=c8&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309995039552&s=260435632&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A3033204114458B7F45726F740852C41E7373696D085D852B696F6E203A00D46730705D203A59CA6D36355D2E0C5A925F00000000&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=2&pi=1251309994842880&ff=0&co=CF0D1C3D89B85F0F5030D63282BC55B0&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=C611578E26907D813AF8645D8C71E9B7");
//items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=x83GCmTs4/+HrWklyVF//AHULGNDVS0PAAAAAM+MqxPWLzxediC+i9kivtpPAu79&mid=666&threshold=150&tid=9929E7F8C6F5A9081A7C3156D459CE97&srcid=4&verno=1&g=CF8CAB13D62F3C5E7620BE8BD922BEDA4F02EEFD&scn=c6&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309994974016&s=254629187&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A303420540E458533205269630A508833205B313059019402205B682E5307D1022E6D6B76&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=1&pi=1251309994842880&ff=0&co=302EC59C8BDA88362AE2603380D4C1EB&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=1939500AFE478AB38686B38BD312C243");
//items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=uSmUaQluYYUJ8k4VYGS2S8rbpcsJhYkMAAAAANEnDDQb5O4Kr/ZnJknR2aZHw1Om&mid=666&threshold=150&tid=6B19C6860F65858523F0860B4B1CDC22&srcid=4&verno=1&g=D1270C341BE4EE0AAFF6672649D1D9A647C353A6&scn=c6&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309994908480&s=210339081&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A303520470445C40C6368776907459D7F5B3130385141B97F5B682E325704B9716D6B7600&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=0&pi=1251309994842880&ff=0&co=5DDE541303B487287AB241A88223FF45&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=D0E2AFC2ABAE66D3EAAF5125DDE09B21");
items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=v7Zpw5zPdnxclqJcCvLDbs+JKBiWkH8NAAAAAONJgNGCugkGQwb0wnu2pFV/FW3H&mid=666&threshold=150&tid=FA16CE7F59DC1A6E6FFF05EEF361B6D8&srcid=4&verno=1&g=E34980D182BA09064306F4C27BB6A4557F156DC7&scn=c6&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309995105088&s=226463894&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A303620540954C40D69636B73417C912C742062654172963E7A79205B5001DC6F705D205B091FD669355D2E6D0A47E45F00000000&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=3&pi=1251309994842880&ff=0&co=192CF6AE5817B6DEF5C6D6109EA39926&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=DF39365A4B89C70DDF37CDB4B85478F2");
items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=ttVyel6DT2C87cgOGb0tOorAveTUnX8MAAAAAFFbk9GIQN1FX56Jlm5YuM0puovb&mid=666&threshold=150&tid=3A7E5A254B0F912FFC8DD2277C472502&srcid=4&verno=1&g=515B93D18840DD455F9E89966E58B8CD29BA8BDB&scn=c6&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309995170624&s=209690068&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A303720420856C40B726F75620D54C4366E204C691545883A2053616E02598125205B313059019402205B682E5307D1022E6D6B76&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=4&pi=1251309994842880&ff=0&co=E2B41C74363AB264218607F2E729D85D&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=781B0035C1F67A7687E51ABAEB7D8EA0");
//items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=DIqtINLQPLJos5hNt/Mu0HMm559GvXEMAAAAAOHjZeWXvfvz55fHvdL7dn67JXbI&mid=666&threshold=150&tid=5A1C548169B4D0AB775EA99DBBA97148&srcid=4&verno=1&g=E1E365E597BDFBF3E797C7BDD2FB767EBB2576C8&scn=c12&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309995367232&s=208780614&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A303820490F45812D64696D650F428D306E616C2022508633652032203554892F74696E674177852B65205B315109D42F5D205B684F03D26A5D2E6D6B1731E45F00000000&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=7&pi=1251309994842880&ff=0&co=390ECBE104CBDD5DD9DF9B36661F5753&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=36E71D11503C0143494FB154C37C474A");
//items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=6Y3wPIgPyK/KRrOiHkwrV4jZbD66IaQKAAAAAPda7BL4g+JDhrmjn+jPwLsx/JhP&mid=666&threshold=150&tid=DF42E093482E5D6E6939A40D038A7851&srcid=4&verno=1&g=F75AEC12F883E24386B9A39FE8CFC0BB31FC984F&scn=c23&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309995301696&s=178528698&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A3039204C0E5E8F7F57686F734161912D67696E67417F8B28205B313059019402205B682E5307D1022E6D6B76&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=6&pi=1251309994842880&ff=0&co=4CC3D5906BEA37470669D0846B4937AF&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=18043807E513C21BBE73C6DCBF1782C8");
//items.Add("http://gdl.lixian.vip.xunlei.com/download?fid=sKl/WlHqtmoPXPd87xFzTyFB6QHSHSMMAAAAAFRzusO0c6alT7l7STXUaiJURFh6&mid=666&threshold=150&tid=C48E3FF619139524CAB52894C138F03A&srcid=4&verno=1&g=5473BAC3B473A6A54FB97B4935D46A225444587A&scn=c20&i=0494A80532B5B05DDE567C61220D93406B7E22E7&t=6&ui=551334162&ti=1251309995236160&s=203627986&m=0&n=013A41973A75646F5D41638D3C6B20616E0511A930727479203201D61A313020540954C408656464690F56C40C7175616E0259812D73205B315109D42F5D205B684F03D26A5D2E6D6B1731E45F00000000&ih=0494A80532B5B05DDE567C61220D93406B7E22E7&fi=5&pi=1251309994842880&ff=0&co=0E4021B79C5A6B39E35DEBD5BA263541&cm=1&pk=lixian&ak=1:0:1:3&e=1463566907&ms=10485760&ck=25A4233F9F85C63636FF74AE7BB74914&at=EA80534ED07E66D7FC6DBDF83611B043");
items.Add("");
items.Add("");
items.Add("");
items.Add("");
new Sulfate().Download(cookie, items, folder);

Console.WriteLine("Exit");