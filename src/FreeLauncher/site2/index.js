var g_selectedNickname='';

var g_serv; //;TO_EDIT
var select = 0;


g_serv={"current_page":"2","data":[{"addr":"imperia-craft.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6265","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6265","color":"","icon_src":"","id":"6265","name":"IMPERIA-CRAFT 1.8-1.12","now_online":"1","online":"0","rating":"47","score":"0","short_desc":"IP imperia-craft.ru \u041D\u043E\u0432\u044B\u0439 \u0441\u0435\u0440\u0432\u0435\u0440 \u043C\u0430\u0439\u043D\u043A\u0440\u0430\u0444\u0442 \u041C\u0438\u043D\u0438 \u0418\u0433\u0440\u044B BedWars \u0438 SkyWars","site":"http:\/\/www.imperia-craft.ru","slots":"200","url":"https:\/\/mc-monitoring.info\/server\/6265","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6265"},{"addr":"46.174.48.33:25741","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6424","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6424","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/MluVbpLXrG.png","id":"6424","name":"Green House","now_online":"1","online":"0","rating":"44","score":"0","short_desc":" \u0410\u0442\u043C\u043E\u0441\u0444\u0435\u0440\u043D\u044B\u0439 \u0441\u0435\u0440\u0432\u0435\u0440 \u0434\u043B\u044F \u0438\u0433\u0440\u044B \u0441 \u0434\u0440\u0443\u0437\u044C\u044F\u043C\u0438 \u0438\u043B\u0438 \u0436\u0435 \u0441\u0430\u043C\u043E\u043C\u0443, \u043F\u0440\u0438\u0441\u043E\u0435\u0434\u0438\u043D\u044F\u0439\u0442\u0435\u0441\u044C ","site":"","slots":"15","url":"https:\/\/mc-monitoring.info\/server\/6424","version":"1.13.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6424"},{"addr":"212.22.93.47:26335","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6200","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6200","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/bw9cIx5mnn.png","id":"6200","name":"CraftDan 1.8-1.13.2","now_online":"1","online":"0","rating":"33","score":"0","short_desc":"\u0414\u043E\u043D\u0430\u0442 cdpay.mcdonate.ru - \u0412\u041A vk.com club163023334 - \u043F\u0440\u0438\u0441\u043E\u0435\u0434\u0438\u043D\u044F\u0439\u0441\u044F \u043A \u043D\u0430\u043C.","site":"https:\/\/cdpay.mcdonate.ru","slots":"100","url":"https:\/\/mc-monitoring.info\/server\/6200","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6200"},{"addr":"mc.void-craft.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=3219","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=3219","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/lOEgOSDjKD.jpg","id":"3219","name":"Void-Craft","now_online":"1","online":"16","rating":"31","score":"0","short_desc":"\u041A\u0440\u0430\u0441\u0438\u0432\u044B\u0439 \u0441\u043F\u0430\u0432\u043D \u0441 \u0434\u0432\u0443\u043C\u044F \u043C\u0438\u0440\u0430\u043C\u0438 \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u044F \u0438 \u0432\u0441\u0435\u043C \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u044B\u043C \u0434\u043B\u044F \u0438\u0433\u0440\u044B \u0438 \u0440\u0430\u0437\u0432\u043B\u0435\u0447\u0435\u043D\u0438\u044F","site":"http:\/\/void-craft.ru","slots":"1000","url":"https:\/\/mc-monitoring.info\/server\/3219","version":"1.13.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/3219"},{"addr":"mc.mccraft.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=2343","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=2343","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/DHlMYn8zMO.jpg","id":"2343","name":"McCraft","now_online":"1","online":"2","rating":"30","score":"0","short_desc":"\u041E\u0442\u043B\u0438\u0447\u043D\u043E\u0435, \u043A\u0440\u0430\u0441\u0438\u0432\u043E\u0435 \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435","site":"http:\/\/mccraft.ru","slots":"500","url":"https:\/\/mc-monitoring.info\/server\/2343","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/2343"},{"addr":"mc.mexworld.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=1271","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=1271","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/hh8wFBz8k4.jpg","id":"1271","name":"MexWorld","now_online":"1","online":"190","rating":"30","score":"0","short_desc":"\u0420\u0430\u0437\u0432\u0438\u0432\u0430\u044E\u0449\u0438\u0439\u0441\u044F \u0441\u0435\u0440\u0432\u0435\u0440, \u0430\u0434\u0435\u043A\u0432\u0430\u0442\u043D\u044B\u0435 \u0430\u0434\u043C\u0438\u043D\u044B, \u0432\u0441\u0435\u043C \u0432\u0438\u043F, \u0431\u0435\u0441\u043F\u043B\u0430\u0442\u043D\u044B\u0439 \u0434\u043E\u043D\u0430\u0442 \u0437\u0430 \u0432\u0440\u0435\u043C\u044F \u0438\u0433\u0440\u044B, \u0434\u0435\u0448\u0435\u0432\u044B\u0439 \u0434\u043E\u043D\u0430\u0442","site":"http:\/\/mexworld-shop.ru\/","slots":"2019","url":"https:\/\/mc-monitoring.info\/server\/1271","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/1271"},{"addr":"go.scapemc.ru:19132","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=5926","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=5926","color":"","icon_src":"","id":"5926","name":"MineScape.proxy.1","now_online":"1","online":"14","rating":"25","score":"0","short_desc":"\u0420\u0410\u041D\u0413\u0418 - \u0414\u041E\u041D\u0410\u0422-\u041A\u0415\u0419\u0421\u042B- \u0411\u0410\u0422\u0423\u0422\u042B - \u041B\u0410\u0411\u0418\u0420\u0418\u041D\u0422 - \u0428\u0410\u0425\u0422\u0410 - \u0411\u0415\u0417 \u041E\u0411\u041C\u0410\u041D\u0410","site":"https:\/\/scapemc.ru","slots":"200","url":"https:\/\/mc-monitoring.info\/server\/5926","version":"\u041F\u0415","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/5926"},{"addr":"212.22.93.72:26200","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6525","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6525","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/jWF9mDMd4L.png","id":"6525","name":"Am.City","now_online":"1","online":"1","rating":"25","score":"0","short_desc":"Am.City \u044D\u0442\u043E \u0441\u0435\u0440\u0432\u0435\u0440 \u0433\u0434\u0435 \u043C\u0438\u0440 \u0431\u0443\u0434\u0435\u0442 \u0433\u043E\u0440\u043E\u0434\u043E\u043C","site":"https:\/\/am-city.mcdonate.ru","slots":"80","url":"https:\/\/mc-monitoring.info\/server\/6525","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6525"},{"addr":"mc.mysticalstory.net:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=5241","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=5241","color":"","icon_src":"","id":"5241","name":"MysticalStory","now_online":"1","online":"0","rating":"24","score":"0","short_desc":"\u0423\u043D\u0438\u043A\u0430\u043B\u044C\u043D\u044B\u0435 \u0441\u0435\u0440\u0432\u0435\u0440\u0430 \u0431\u0435\u0437 \u043C\u043E\u0434\u043E\u0432","site":"https:\/\/mysticalstory.net","slots":"100","url":"https:\/\/mc-monitoring.info\/server\/5241","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/5241"},{"addr":"chip.24serv.pro:16016","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=4614","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=4614","color":"","icon_src":"","id":"4614","name":"MinjaCraft - 1.0.5 - 1.0.9","now_online":"1","online":"374","rating":"23","score":"0","short_desc":"\u0417\u0430\u0445\u043E\u0434\u0438 \u0441 \u043D\u0430\u043C\u0438 \u0432\u0435\u0441\u0435\u043B\u0435\u0439","site":"","slots":"2019","url":"https:\/\/mc-monitoring.info\/server\/4614","version":"\u041F\u0415 1.0.5","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/4614"},{"addr":"steakmc.playvdss.org:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=5795","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=5795","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/DRRRlpC9JE.png","id":"5795","name":"SteakMine","now_online":"1","online":"10","rating":"23","score":"0","short_desc":"\u0423\u043D\u0438\u043A\u0430\u043B\u044C\u043D\u0430\u044F \u0441\u043C\u0435\u0441\u044C \u0433\u0440\u0438\u0444\u0435\u0440\u0441\u0442\u0432\u0430 \u0438 \u0430\u043D\u0430\u0440\u0445\u0438\u0438...","site":"http:\/\/steakmc.mcdonate.ru","slots":"150","url":"https:\/\/mc-monitoring.info\/server\/5795","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/5795"},{"addr":"188.40.45.197:36875","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6626","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6626","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/WlayJDYBfW.png","id":"6626","name":"XionioX \u043E\u0440\u0438\u0433\u0438\u043D\u0430\u043B\u044C\u043D\u044B\u0439 1.8-1.14","now_online":"1","online":"15","rating":"22","score":"0","short_desc":"\u041D\u0435\u0442 \u0434\u043E\u043D\u0430\u0442\u0430","site":"","slots":"20","url":"https:\/\/mc-monitoring.info\/server\/6626","version":"1.14","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6626"},{"addr":"rumcraft.nbb.wtf:25925","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6492","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6492","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/eoJyY1NYHY.png","id":"6492","name":"\u0414\u041E\u041D\u0410\u0422 \u0412\u0421\u0415\u041C \u0411\u0415\u0421\u041F\u041B\u0410\u0422\u041DO","now_online":"1","online":"0","rating":"21","score":"0","short_desc":"RumCraft Offical","site":"https:\/\/rum.mcdonate.ru","slots":"20","url":"https:\/\/mc-monitoring.info\/server\/6492","version":"1.8","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6492"},{"addr":"mc.ironsquid.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=758","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=758","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/JMr0MGmjoS.png","id":"758","name":"IronSquid \u0425\u0430\u0440\u0434 \u0421\u043A\u0430\u0439\u0431\u043B\u043E\u043A \u0413\u0440\u0438\u0444","now_online":"1","online":"16","rating":"21","score":"0","short_desc":"\u0411\u043B\u043E\u043A\u0438 \u0438\u0437 1.13.2 \u041C\u043D\u043E\u0433\u043E \u0441\u0435\u0440\u0432\u0435\u0440\u043E\u0432","site":"http:\/\/ironsquid.ru\/","slots":"1000","url":"https:\/\/mc-monitoring.info\/server\/758","version":"1.13.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/758"},{"addr":"sim.md:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=1329","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=1329","color":"null","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/fFFHViflXi.png","id":"1329","name":"BirchCraft \u0441\u043F\u043E\u043A\u043E\u0439\u043D\u043E\u0435 \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435","now_online":"1","online":"0","rating":"20","score":"0","short_desc":"\u0421\u0430\u043C\u043E\u0435 \u043E\u0431\u044B\u0447\u043D\u043E\u0435 \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435, \u0431\u0435\u0437 \u043F\u0440\u0438\u0432\u0430\u0442\u0430 \u0438 \u043F\u0440\u043E\u0447\u0438\u0445 \u043F\u043B\u0430\u0433\u0438\u043D\u043E\u0432. ","site":"","slots":"8","url":"https:\/\/mc-monitoring.info\/server\/1329","version":"1.13.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/1329"},{"addr":"212.22.93.72:25730","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6293","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6293","color":"","icon_src":"","id":"6293","name":"SparkCraft Vanilla","now_online":"1","online":"2","rating":"20","score":"0","short_desc":"\u041A\u043B\u0430\u0441\u0441\u0438\u0447\u0435\u0441\u043A\u043E\u0435 \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435 \u0431\u0435\u0437 \u043F\u043B\u0430\u0433\u0438\u043D\u043E\u0432 \u0438 \u0434\u043E\u043D\u0430\u0442\u0430. \u0410\u0434\u0435\u043A\u0432\u0430\u0442\u043D\u044B\u0435 \u0438\u0433\u0440\u043E\u043A\u0438, \u043F\u0440\u0438\u044F\u0442\u043D\u0430\u044F \u0430\u0442\u043C\u043E\u0441\u0444\u0435\u0440\u0430. \u0418\u043C\u0435\u043D\u043D\u043E \u044D\u0442\u043E \u0442\u044B \u0438 \u0438\u0441\u043A\u0430\u043B.","site":"https:\/\/vanilla.sparkcraft.ru\/","slots":"30","url":"https:\/\/mc-monitoring.info\/server\/6293","version":"1.13.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6293"},{"addr":"164.132.203.64:25560","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6457","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6457","color":"null","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/EA38AZEhdM.jpg","id":"6457","name":"\u0428\u041E\u041A - EmzyMine 2.0","now_online":"1","online":"5","rating":"18","score":"0","short_desc":"\u041F\u0435\u0440\u0432\u044B\u0439 \u0441\u0435\u0440\u0432\u0435\u0440, \u043A\u043E\u0442\u043E\u0440\u044B\u0439 \u0420\u0415\u0410\u041B\u042C\u041D\u041E \u0420\u0410\u0417\u0414\u0410\u0401\u0422 \u0414\u041E\u041D\u0410\u0422","site":"https:\/\/venerdon.mcdonate.ru\/","slots":"1000","url":"https:\/\/mc-monitoring.info\/server\/6457","version":"1.8","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6457"},{"addr":"zertix.ru:19132","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=3250","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=3250","color":"","icon_src":"","id":"3250","name":"ZerTiX - \u041F\u043E\u0441\u0442\u0430\u043F\u043E\u043A\u0430\u043B\u0438\u043F\u0441\u0438\u0441","now_online":"1","online":"18","rating":"18","score":"0","short_desc":"\u0423\u0439\u043C\u0430 \u043E\u0440\u0443\u0436\u0438\u044F, \u0437\u043E\u043C\u0431\u0438, \u0432\u043E\u0437\u043C\u043E\u0436\u043D\u043E\u0441\u0442\u044C \u043E\u0431\u044A\u0435\u0434\u0438\u043D\u044F\u0442\u044C\u0441\u044F \u0432 \u0433\u0440\u0443\u043F\u043F\u0438\u0440\u043E\u0432\u043A\u0438, \u0438 \u0442. \u043F.  \u0436\u0434\u0451\u0442 \u0412\u0430\u0441 \u043D\u0430 \u0441\u0435\u0440\u0432\u0435\u0440\u0435 - ZerTiX","site":"https:\/\/zertix.ru","slots":"100","url":"https:\/\/mc-monitoring.info\/server\/3250","version":"\u041F\u0415","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/3250"},{"addr":"mc.qmine.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=4828","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=4828","color":"","icon_src":"","id":"4828","name":"meee","now_online":"1","online":"193","rating":"18","score":"0","short_desc":"\u0441\u0435\u0440\u0432\u0435\u0440 \u0434\u043B\u044F \u0440\u0435\u0430\u043B\u044C\u043D\u044B\u0445 \u043C\u0430\u0438\u043D\u043A\u0440\u0430\u0444\u0442\u0435\u0440\u043E\u0432","site":"https:\/\/api.browser.yandex.ru\/elements\/embeddedauth.html","slots":"1337","url":"https:\/\/mc-monitoring.info\/server\/4828","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/4828"},{"addr":"78.46.102.123:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=1827","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=1827","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/x0BFVtlGEB.png","id":"1827","name":"JC-WORLD","now_online":"1","online":"1","rating":"17","score":"0","short_desc":"\u0415\u0436\u0435\u0434\u043D\u0435\u0432\u043D\u044B\u0435 \u043A\u0435\u0439\u0441\u044B, \u0434\u0443\u044D\u043B\u0438, \u043F\u0430\u0440\u043A\u0443\u0440-\u0430\u0440\u0435\u043D\u044B, \u044D\u043A\u043E\u043D\u043E\u043C\u0438\u043A\u0430, \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435, \u0438\u0432\u0435\u043D\u0442\u044B \u043D\u0430 \u0434\u043E\u043D\u0430\u0442, \u043F\u0432\u043F-\u0430\u0440\u0435\u043D\u0430","site":"","slots":"30","url":"https:\/\/mc-monitoring.info\/server\/1827","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/1827"},{"addr":"play.architectmc.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=2852","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=2852","color":"","icon_src":"","id":"2852","name":"ArchiTect","now_online":"1","online":"4","rating":"17","score":"0","short_desc":"","site":"http:\/\/donate.architectmc.ru\/","slots":"2000","url":"https:\/\/mc-monitoring.info\/server\/2852","version":"1.13.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/2852"},{"addr":"Play.TeslaCraft.org:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=50","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=50","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/O9qd549Fbb.png","id":"50","name":"TeslaCraft","now_online":"1","online":"2340","rating":"16","score":"0","short_desc":"TeslaCraft - \u044D\u0442\u043E \u0442\u043E\u0442 \u0441\u0435\u0440\u0432\u0435\u0440, \u043D\u0430 \u043A\u043E\u0442\u043E\u0440\u043E\u043C \u0432\u0441\u0435 \u043F\u0440\u043E\u0434\u0443\u043C\u0430\u043D\u043E \u0434\u043E \u043C\u0435\u043B\u043E\u0447\u0435\u0439","site":"http:\/\/TeslaCraft.org\/","slots":"4000","url":"https:\/\/mc-monitoring.info\/server\/50","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/50"},{"addr":"MC-Killer.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6436","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6436","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/PUAZWoYH48.png","id":"6436","name":"\u041C\u0418\u041D\u0418-\u0418\u0413\u0420\u042B \u0412\u042B\u0416\u0418\u0412\u0410\u041D\u0418\u0415 1.12.2","now_online":"1","online":"1","rating":"15","score":"0","short_desc":"\u041C\u0438\u043D\u0438-\u0438\u0433\u0440\u044B SkyWars, BedWars \u0438 BuildBattle. \u0414\u043E\u0441\u0442\u0438\u0436\u0435\u043D\u0438\u044F \u0438 \u0441\u0438\u0441\u0442\u0435\u043C\u0430 \u0443\u0440\u043E\u0432\u043D\u0435\u0439 \u043D\u0430 \u043C\u0438\u043D\u0438-\u0438\u0433\u0440\u0430\u0445. \u0412\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435 \u0441 \u043A\u043B\u0430\u043D\u0430\u043C\u0438, \u043F\u0438\u0442\u043E\u043C\u0446\u0430\u043C\u0438, \u0441\u0432\u0430\u0434\u044C\u0431\u043E\u0439.","site":"http:\/\/MCKiller.ru","slots":"2018","url":"https:\/\/mc-monitoring.info\/server\/6436","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6436"},{"addr":"foracraft.pp.ua:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=4686","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=4686","color":"","icon_src":"","id":"4686","name":"ForaCraft 1.14 - 1.13.2","now_online":"1","online":"16","rating":"15","score":"0","short_desc":"\u0425\u043E\u0440\u043E\u0448\u0438\u0439 \u0441\u0435\u0440\u0432\u0435\u0440 \u0441 \u043F\u0440\u0438\u044F\u0442\u043D\u043E\u0439 \u0430\u0442\u043C\u043E\u0441\u0444\u0435\u0440\u043E\u0439. \u0412\u0445\u043E\u0434 \u043E\u0442 \u0432\u0435\u0440\u0441\u0438\u0438 1.13","site":"https:\/\/foracraft.trademc.org\/","slots":"100","url":"https:\/\/mc-monitoring.info\/server\/4686","version":"1.14","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/4686"},{"addr":"bmpe.pw:19135","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=108","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=108","color":"","icon_src":"","id":"108","name":" BloodMine 4","now_online":"1","online":"68","rating":"15","score":"0","short_desc":"","site":"http:\/\/blodmine1.trademc.org","slots":"150","url":"https:\/\/mc-monitoring.info\/server\/108","version":"\u041F\u0415 0.16.0","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/108"},{"addr":"my.servokio.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6464","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6464","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/RvA1DPRhRD.png","id":"6464","name":"ServOKio","now_online":"1","online":"1","rating":"13","score":"0","short_desc":"\u041F\u0440\u043E\u0441\u0442\u043E \u0441\u0435\u0440\u0432\u0435\u0440 \u043C\u0430\u0439\u043D\u043A\u0440\u0430\u0444\u0442","site":"http:\/\/servokio.ru","slots":"5","url":"https:\/\/mc-monitoring.info\/server\/6464","version":"1.12","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6464"},{"addr":"flux-mc.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6275","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6275","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/GJmCsxOjaG.png","id":"6275","name":"FluxMC","now_online":"1","online":"4","rating":"13","score":"0","short_desc":"\u041F\u0430\u043D\u0435\u043B\u044C \u044E\u0442\u0443\u0431\u0435\u0440\u0430, \u043A\u043E\u043D\u0441\u043E\u043B\u044C, \u043D\u0430\u0431\u043E\u0440 \u0433\u0440\u0438\u0444\u0435\u0440\u0430, \u0430\u0432\u0442\u043E\u0448\u0430\u0445\u0442\u0430, \u043A\u0435\u0439\u0441\u044B, \u0441\u0432\u0430\u0434\u044C\u0431\u044B, \u043A\u0430\u0437\u0438\u043D\u043E \u0438 \u043C\u043D\u043E\u0433\u043E\u0435 \u0434\u0440\u0443\u0433\u043E\u0435","site":"http:\/\/donate.flux-mc.ru\/","slots":"100","url":"https:\/\/mc-monitoring.info\/server\/6275","version":"1.8","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6275"},{"addr":"soulcraft-pe.ru:19132","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=2708","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=2708","color":"","icon_src":"","id":"2708","name":"SoulCraft 1.0.5 - 1.2.x","now_online":"1","online":"228","rating":"13","score":"0","short_desc":"\u041B\u0443\u0447\u0448\u0438\u0439 \u0441\u0435\u0440\u0432\u0435\u0440 \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u044F \u0441 \u043C\u0438\u043D\u0438\u0438\u0433\u0440\u0430\u043C\u0438 \u0432 Minecraft PE","site":"http:\/\/soulcraft-pe.ru","slots":"999","url":"https:\/\/mc-monitoring.info\/server\/2708","version":"\u041F\u0415","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/2708"},{"addr":"212.22.93.39:25610","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6378","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6378","color":"","icon_src":"","id":"6378","name":"Vostorg Craft","now_online":"1","online":"0","rating":"13","score":"0","short_desc":"","site":"","slots":"10","url":"https:\/\/mc-monitoring.info\/server\/6378","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6378"},{"addr":"wasd.24serv.pro:12014","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=5389","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=5389","color":"","icon_src":"","id":"5389","name":"BudleLand MCPE","now_online":"1","online":"0","rating":"12","score":"0","short_desc":"1 \u043A\u043B\u044E\u0447 \u043E\u0442 \u0434\u043E\u043D\u0430\u0442 \u043A\u0435\u0439\u0441\u0430 \u0431\u0435\u0441\u043F\u043B\u0430\u0442\u043D\u044B\u0439 ","site":"http:\/\/BudleLandDonate.trademc.org","slots":"90","url":"https:\/\/mc-monitoring.info\/server\/5389","version":"\u041F\u0415 1.0.5","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/5389"},{"addr":"PvP.PigRaid.com:19132","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=109","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=109","color":"","icon_src":"","id":"109","name":" Pig Raid","now_online":"1","online":"28","rating":"12","score":"0","short_desc":"","site":"http:\/\/pigraid.com\/","slots":"325","url":"https:\/\/mc-monitoring.info\/server\/109","version":"\u041F\u0415 1.0.7","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/109"},{"addr":"212.22.93.71:25750","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6394","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6394","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/jNSxSnpUg6.jpg","id":"6394","name":"YouGC Mine","now_online":"1","online":"3","rating":"12","score":"0","short_desc":"\u0414\u043E\u0431\u0440\u043E \u043F\u043E\u0436\u0430\u043B\u043E\u0432\u0430\u0442\u044C \u043D\u0430 \u043D\u0430\u0448 \u0441\u0435\u0440\u0432\u0435\u0440, \u043C\u044B \u0432\u0430\u0441 \u0436\u0434\u0451\u043C. ","site":"","slots":"50","url":"https:\/\/mc-monitoring.info\/server\/6394","version":"1.13.1","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6394"},{"addr":"mc.xenolith.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6004","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6004","color":"","icon_src":"","id":"6004","name":"Xenolith - 1.14","now_online":"1","online":"7","rating":"11","score":"0","short_desc":"\u041A\u043B\u0430\u0441\u0441\u0438\u0447\u0435\u0441\u043A\u0438\u0435 \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435 \u0431\u0435\u0437 \u0434\u043E\u043D\u0430\u0442\u0430, \u043E\u0442\u0434\u0435\u043B\u044C\u043D\u044B\u0439 \u043A\u0440\u0435\u0430\u0442\u0438\u0432 \u0438 \u0441\u043A\u0430\u0439\u0431\u043B\u043E\u043A \u0441\u0435\u0440\u0432\u0435\u0440, \u0430 \u0442\u0430\u043A \u0436\u0435 \u043C\u0438\u043D\u0438-\u0438\u0433\u0440\u044B Gravity, Blockparty \u0438 \u0434\u0440\u0443\u0433\u0438\u0435...","site":"https:\/\/xenolith.ru","slots":"50","url":"https:\/\/mc-monitoring.info\/server\/6004","version":"1.14","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6004"},{"addr":"mc.s4mine.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6540","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6540","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/z69oH6wdtm.png","id":"6540","name":"S4MINE - \u0412\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435, StarWars","now_online":"1","online":"123","rating":"11","score":"0","short_desc":"\u041E\u0442\u043B\u0438\u0447\u043D\u044B\u0435 \u0441\u0435\u0440\u0432\u0435\u0440\u0430 Minecraft \u0441 \u0431\u043E\u043B\u044C\u0448\u0438\u043C \u043D\u0430\u0431\u043E\u0440\u043E\u043C \u043F\u043B\u0430\u0433\u0438\u043D\u043E\u0432 \u0438 \u0440\u0435\u0436\u0438\u043C\u043E\u0432.","site":"https:\/\/s4mine.ru","slots":"2019","url":"https:\/\/mc-monitoring.info\/server\/6540","version":"1.12","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6540"},{"addr":"mc.pluginworld.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=3161","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=3161","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/w4XtdAVgVK.png","id":"3161","name":"PluginWorld Network","now_online":"1","online":"13","rating":"10","score":"0","short_desc":"\u041F\u0440\u043E\u0435\u043A\u0442 \u0441 \u043D\u0435\u0431\u043E\u043B\u044C\u0448\u0438\u043C\u0438 \u0441\u0435\u0440\u0432\u0435\u0440\u0430\u043C\u0438, \u0442\u0430\u043A\u0438\u043C\u0438 \u043A\u0430\u043A \u0410\u0440\u043A\u0430\u0434\u043D\u044B\u0439, \u0445\u0430\u0440\u0434\u043A\u043E\u0440\u043D\u044B\u0439 \u0438 \u043C\u0438\u043D\u0438-\u0438\u0433\u0440\u044B.","site":"http:\/\/pluginworld.ru\/","slots":"300","url":"https:\/\/mc-monitoring.info\/server\/3161","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/3161"},{"addr":"play.WizeWorld.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=4756","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=4756","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/9aJzdJzoo7.png","id":"4756","name":"WizeWorld","now_online":"1","online":"2","rating":"9","score":"0","short_desc":"WizeWorld  - \u0441\u0435\u0440\u0432\u0435\u0440, \u043A\u043E\u0442\u043E\u0440\u044B\u0439 \u0436\u0434\u0435\u0442 \u0442\u0435\u0431\u044F","site":"https:\/\/www.wizeworld.ru","slots":"1337","url":"https:\/\/mc-monitoring.info\/server\/4756","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/4756"},{"addr":"mc.hypixel.net:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=265","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=265","color":"null","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/NbZM7BQjqt.png","id":"265","name":"\u0425\u0430\u0439\u041F\u0438\u043A\u0441\u0435\u043B\u044C 1.8-1.12 \u0412\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435","now_online":"1","online":"23654","rating":"8","score":"0","short_desc":"\u0418\u0433\u0440\u043E\u0432\u043E\u0439 \u0441\u0435\u0440\u0432\u0435\u0440 \u0425\u0430\u0439\u041F\u0438\u043A\u0441\u0435\u043B\u044C","site":"https:\/\/hypixel.net","slots":"36000","url":"https:\/\/mc-monitoring.info\/server\/265","version":"1.12","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/265"},{"addr":"148.251.247.211:25571","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6193","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6193","color":"","icon_src":"","id":"6193","name":"GTNewHorizons-Reloaded","now_online":"1","online":"8","rating":"8","score":"0","short_desc":"\u0412 \u043E\u0431\u0449\u0435\u043C \u0442\u044B \u0432\u0440\u044F\u0434 \u043B\u0438 \u0432\u044B\u0436\u0438\u0432\u0435\u0448\u044C \u0442\u0443\u0442. \u0422\u043E\u0442 \u043A\u0442\u043E \u0441\u043E\u0431\u0438\u0440\u0430\u043B \u044D\u0442\u043E\u0442 \u0441\u0435\u0440\u0432\u0435\u0440 \u043D\u0430\u0441\u0442\u043E\u044F\u0449\u0438\u0439 \u043C\u0430\u043D\u044C\u044F\u043A.","site":"https:\/\/gmc.divinity.tech","slots":"20","url":"https:\/\/mc-monitoring.info\/server\/6193","version":"1.7.10","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6193"},{"addr":"play.mcaero.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=4676","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=4676","color":"null","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/m884l3QYWM.png","id":"4676","name":"AeroCraft 1.8-1.13.2 \u041C\u0410\u0413\u0418\u042F","now_online":"1","online":"28","rating":"8","score":"0","short_desc":"\u041D\u0410\u0428 IP - PLAY.MCAERO.RU, \u041C\u042B \u0420\u0410\u0411\u041E\u0422\u0410\u0415\u041C \u0423\u0416\u0415 \u0411\u041E\u041B\u0415\u0415 4-\u0425 \u041B\u0415\u0422","site":"http:\/\/aero-craft.ru","slots":"500","url":"https:\/\/mc-monitoring.info\/server\/4676","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/4676"},{"addr":"mc.trickmine.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=5057","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=5057","color":"cl-2","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/akvegl1G5D.png","id":"5057","name":"TrickMine","now_online":"1","online":"11","rating":"8","score":"0","short_desc":"\u041E\u043B\u0434\u044B \u0437\u0434\u0435\u0441\u044C.","site":"https:\/\/trickminemc.mcdonate.ru","slots":"40","url":"https:\/\/mc-monitoring.info\/server\/5057","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/5057"},{"addr":"78.46.102.124:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6607","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6607","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/7byJJvLsjO.png","id":"6607","name":"LibertyClanWar","now_online":"1","online":"1","rating":"8","score":"0","short_desc":"\u041A\u043B\u0430\u043D\u043E\u0432\u044B\u0435 \u0432\u043E\u0439\u043D\u044B, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0434\u0435\u043B\u0430\u043B\u0438 \u0434\u043B\u044F \u0432\u0430\u0441","site":"https:\/\/libertycw.trademc.org\/","slots":"500","url":"https:\/\/mc-monitoring.info\/server\/6607","version":"1.13.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6607"},{"addr":"212.22.93.71:25810","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6619","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6619","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/xluYbkAbLt.png","id":"6619","name":"CyberCraft","now_online":"1","online":"7","rating":"8","score":"0","short_desc":"\u041D\u043E\u0432\u044B\u0439 \u0432\u0430\u043D\u0438\u043B\u044C\u043D\u044B\u0439 \u0441\u0435\u0440\u0432\u0435\u0440 \u0440\u0430\u0431\u043E\u0442\u0430\u044E\u0449\u0435\u0439 \u043D\u0430 \u043F\u043E\u0441\u043B\u0435\u0434\u043D\u0435\u0439 \u0432\u0435\u0440\u0441\u0438\u0438 Minecraft 1.14.X","site":"","slots":"50","url":"https:\/\/mc-monitoring.info\/server\/6619","version":"1.14","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6619"},{"addr":"s1.divinity.tech:25567","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=4072","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=4072","color":"","icon_src":"","id":"4072","name":"MagicWorld-Adventure","now_online":"1","online":"0","rating":"8","score":"0","short_desc":"\u041F\u0440\u0438\u043A\u043B\u044E\u0447\u0435\u043D\u0447\u0435\u0441\u043A\u0438\u0439 \u0441\u0435\u0432\u0435\u0440 \u0434\u043B\u044F \u043B\u044E\u0431\u0438\u0442\u0435\u043B\u0435\u0439 \u0420\u041F\u0413, \u043A\u0432\u0435\u0441\u0442\u043E\u0432 \u0438 \u043F\u0443\u0442\u0435\u0448\u0435\u0441\u0442\u0432\u0438\u0439","site":"https:\/\/gmc.divinity.tech","slots":"30","url":"https:\/\/mc-monitoring.info\/server\/4072","version":"1.7.10","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/4072"},{"addr":"78.46.145.199:25786","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6559","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6559","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/WZsRzVuhZR.png","id":"6559","name":"MilkyWay Version 1.14","now_online":"1","online":"0","rating":"7","score":"0","short_desc":"\u0412\u0441\u0442\u0440\u0435\u0447\u0430\u0435\u043C \u0432\u0441\u0435\u0445 \u0438\u0433\u0440\u043E\u043A\u043E\u0432 \u0441 \u043B\u044E\u0431\u043E\u0432\u044C\u044E, \u0442\u0435\u043F\u043B\u043E\u043C \u0438 \u0434\u043E\u0431\u0440\u043E\u0442\u043E\u0439.","site":"http:\/\/78.46.145.199:8123","slots":"100","url":"https:\/\/mc-monitoring.info\/server\/6559","version":"1.14","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6559"},{"addr":"mc.spr-craft.su:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6311","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6311","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/fIYksVvK0L.png","id":"6311","name":"Spreeng,\u043C\u0430\u0442\u044C \u0435\u0433\u043E,Craft 1.8-12","now_online":"1","online":"5","rating":"7","score":"0","short_desc":"\u0418\u043D\u0442\u0435\u0440\u0435\u0441\u043D\u044B\u0435 \u043A\u0432\u0435\u0441\u0442\u044B, \u0442\u043E\u043F\u043E\u0432\u044B\u0435 \u0444\u0438\u0448\u043A\u0438 \u0434\u043B\u044F \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u044F, \u0441\u043E\u0437\u0434\u0430\u0432\u0430\u0439 \u043C\u0438\u0441\u0441\u0438\u0438, \u043A\u0432\u0435\u0441\u0442\u044B, \u0433\u043E\u0440\u043E\u0434\u0430 \u0421\u0410\u041C","site":"https:\/\/spreengcraft.su","slots":"500","url":"https:\/\/mc-monitoring.info\/server\/6311","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6311"},{"addr":"149.202.86.137:25020","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6118","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6118","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/HqI6esCLYV.png","id":"6118","name":"TLM \u041F\u0440\u0438\u0432\u0430\u0442\u043D\u044B\u0439 \u0441\u0435\u0440\u0432\u0435\u0440 \u041C\u0430\u0439\u043D\u043A\u0440\u0430\u0444\u0442","now_online":"1","online":"2","rating":"7","score":"0","short_desc":"TLM \u041F\u0440\u0438\u0432\u0430\u0442\u043D\u044B\u0439 \u0441\u0435\u0440\u0432\u0435\u0440 \u041C\u0430\u0439\u043D\u043A\u0440\u0430\u0444\u0442 1.14 \u0412\u0425\u041E\u0414 25\u0440","site":"https:\/\/discord.gg\/nUYc3AP","slots":"10","url":"https:\/\/mc-monitoring.info\/server\/6118","version":"1.14","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6118"},{"addr":"5.9.157.166:26889","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6408","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6408","color":"","icon_src":"","id":"6408","name":"MagicEasy 1.8 - 1.11.2","now_online":"1","online":"0","rating":"6","score":"0","short_desc":"\u0422\u043E\u043B\u044C\u043A\u043E \u043D\u0430 MagicEasy \u0412\u044B \u043D\u0430\u0439\u0434\u0451\u0442\u0435 \u043C\u043D\u043E\u0433\u043E \u0438\u043D\u0442\u0435\u0440\u0435\u0441\u043D\u044B\u0445 \u0432\u0435\u0449\u0435\u0439","site":"","slots":"15","url":"https:\/\/mc-monitoring.info\/server\/6408","version":"1.8.8","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6408"},{"addr":"89.163.204.9:25649","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6422","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6422","color":"","icon_src":"","id":"6422","name":"SunnyCra-ft","now_online":"1","online":"0","rating":"6","score":"0","short_desc":"SunnyCraft-\u044D\u0442\u043E \u043D\u043E\u0432\u044B\u0439 \u043F\u0440\u043E\u0435\u043A\u0442 Minecraft \u043A\u043E\u0442\u043E\u0440\u044B\u0439 \u043F\u043E\u0433\u0440\u0443\u0437\u0438\u0442 \u0432\u0430\u0441 \u0432 \u043C\u0438\u0440 \u0442\u0435\u0445\u043D\u043E\u043B\u043E\u0433\u0438\u0439 \u043C\u0430\u0433\u0438\u0438 \u0438 \u0445\u0430\u0440\u0434\u043A\u043E\u0440\u043D\u043E\u0433\u043E \u0432\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435 \u0432 \u0438\u0433\u0440\u0435 Minecraft.","site":"https:\/\/sunnycraft.fun\/","slots":"100","url":"https:\/\/mc-monitoring.info\/server\/6422","version":"1.7.10","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6422"},{"addr":"mc.beandex.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=3102","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=3102","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/fUUSbJ26i8.png","id":"3102","name":"BeanDex SkyTech 1.12.2","now_online":"1","online":"1","rating":"6","score":"0","short_desc":"\u041E\u0442\u043B\u0438\u0447\u043D\u044B\u0439 \u0441\u0435\u0440\u0432\u0435\u0440 \u0434\u043B\u044F \u0438\u0433\u0440\u044B \u0432 \u043A\u043E\u043C\u043F\u0430\u043D\u0438\u0438 \u0434\u0440\u0443\u0437\u0435\u0439. \u0415\u0441\u0442\u044C \u043C\u043E\u0434\u044B \u043D\u0430 1.12.2","site":"https:\/\/www.beandex.ru","slots":"300","url":"https:\/\/mc-monitoring.info\/server\/3102","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/3102"},{"addr":"mc.neko.band:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=5701","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=5701","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/xYoWWrqe9x.png","id":"5701","name":"NEKO.LAND 1.14","now_online":"1","online":"10","rating":"6","score":"0","short_desc":"\u041D\u043E\u0432\u044B\u0435 \u043C\u043E\u0431\u044B - \u041D\u043E\u0432\u0430\u044F \u0433\u0435\u043D\u0435\u0440\u0430\u0446\u0438\u044F - \u0418 \u043F\u0440\u043E\u0441\u0442\u043E \u043A\u043E\u0448\u0435\u0447\u043A\u0438","site":"https:\/\/neko.band","slots":"32","url":"https:\/\/mc-monitoring.info\/server\/5701","version":"1.14.1","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/5701"}],"from":"51","last_page":"119","next_page_url":"https:\/\/mc-monitoring.info\/api\/servers?page=3","per_page":"50","prev_page_url":"https:\/\/mc-monitoring.info\/api\/servers?page=1","to":"100","total":"5917"}

/*
	js-ms_	-> mainscript

	var
		ej	- element jquery
		e	- element
		ev	- event

*/





function DOMready() {
	if(!isAHK())
		AHKinit(),AHKobject.contextmenuEnabled=1,bindButtons();
	if(!isAHK()) {
		//return
		blockServers.clear();
        blockServers.init();
       // for (let i = 0; i < 8000; i++)
       // blockServers.add([{ "addr": "mc.papa-craft.ru:25565", "buy_color_url": "https:\/\/mc-monitoring.info\/buy\/color?server_id=6510", "buy_score_url": "https:\/\/mc-monitoring.info\/buy\/votes?server_id=6510", "color": "", "icon_src": "https:\/\/mc-monitoring.info\/img\/icons\/0wHITRZYpf.png", "id": "6510", "name": "Papa Craft", "now_online": "1", "online": "17", "rating": "7", "score": "100", "short_desc": "\u0411\u0438\u0442\u0432\u0430\u041A\u043B\u0430\u043D\u043E\u0432,\u0411\u0438\u043B\u0434\u0411\u0430\u0442\u043B,\u0421\u043A\u0430\u0439\u0431\u043B\u043E\u043A,\u041C\u043E\u0431\u0410\u0440\u0435\u043D\u0430,\u0421\u043A\u0430\u0439\u0412\u0430\u0440\u0441,\u041A\u0440\u0443\u0442\u043E\u0435 \u0412\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435,\u041E\u0440\u0443\u0436\u0438\u0435,\u041F\u0438\u0442\u043E\u043C\u0446\u044B", "site": "http:\/\/papa-craft.ru", "slots": "2018", "url": "https:\/\/mc-monitoring.info\/server\/6510", "version": "1.12.2", "vote_url": "https:\/\/mc-monitoring.info\/server\/vote\/6510" }]);
        //blockServers.add(g_serv.data);
		//blockServers.add(g_serv.data);
		//blockServers.add(g_serv.data);
		//blockServers.add(g_serv.data);
		//blockServers.add(g_serv.data);
		//blockServers.add(g_serv.data);
	}

	var el=$('.js-icon');
	for(var i = 0; i < el.length; i++)
		fixBackgroundImageSize(el[i])
}



function AHKready() {
	accManager.init();
	verManager.init();
	settingsManager.init();

	var ddl=init_DDL();
	var tt=init_tooltip();
    var tab = TabControl.initAll();
	//if(!isAHK())
	//	return 1;
   
    
	//var filters=AHK.getFilters();
	
	blockFilters.bind();

    servManager.init();
    servManager.getVersionsList();
    servManager.getServerInfo();
    blockServers.clear();
    
    //blockServers.add([{ "addr": "mc.papa-craft.ru:25565", "buy_color_url": "https:\/\/mc-monitoring.info\/buy\/color?server_id=6510", "buy_score_url": "https:\/\/mc-monitoring.info\/buy\/votes?server_id=6510", "color": "", "icon_src": "https:\/\/mc-monitoring.info\/img\/icons\/0wHITRZYpf.png", "id": "6510", "name": "Papa Craft", "now_online": "1", "online": "17", "rating": "7", "score": "100", "short_desc": "\u0411\u0438\u0442\u0432\u0430\u041A\u043B\u0430\u043D\u043E\u0432,\u0411\u0438\u043B\u0434\u0411\u0430\u0442\u043B,\u0421\u043A\u0430\u0439\u0431\u043B\u043E\u043A,\u041C\u043E\u0431\u0410\u0440\u0435\u043D\u0430,\u0421\u043A\u0430\u0439\u0412\u0430\u0440\u0441,\u041A\u0440\u0443\u0442\u043E\u0435 \u0412\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435,\u041E\u0440\u0443\u0436\u0438\u0435,\u041F\u0438\u0442\u043E\u043C\u0446\u044B", "site": "http:\/\/papa-craft.ru", "slots": "2018", "url": "https:\/\/mc-monitoring.info\/server\/6510", "version": "1.12.2", "vote_url": "https:\/\/mc-monitoring.info\/server\/vote\/6510" }]);
    accManager.clear();
    
	//getServers();
	//getAccounts();
	//getSettings();
    
    //accManager.add("sadas");
    //verManager.set({ installed: [["title", "value"]], notinstalled: [["title2", "value2"]] });
    //verManager.set({ installed: [["title7", "value7"]], notinstalled: [["title9", "value9"]] });
   

	//accManager.setAccount(AHK.getChoosedAccount());
	//verManager.setVersion(AHK.getChoosedVersion());
	//updateVersions();
    bindButtons();
    //uiLoader.show();
    //blockInstallProgress.show();
	return 1;
}

function updateVersions() {
	return verManager.set(AHK.verManager('getVersions'));
}

function bindButtons() {
	bindButton($(".js-ms_vermanager_button"),function(e,el) {
		return verManager[$(el).attr("data-act")]();
	});
	bindButton($(".js-ms_show_ver_manager"),function(e,el) {
		return verManager.show();
	});
	bindButton($(".js-ms_show_settings_manager"),function(e,el) {
		return settingsManager.show();
	});



	bindButton($(".js-ms_url_adv_server"),function(e,el) {
        servManager.openUrl("https://mc-monitoring.info/buy");
	});bindButton($(".js-ms_url_add_server"),function(e,el) {
        servManager.openUrl("https://mc-monitoring.info/server/add");
	});


	bindButton($(".js-ms_launchgame"),function(e,el) {
		on_launchgame("","")
	});



	bindButton($(".js-ms-install_progress__cancel_install"),function(e,el) {
		blockInstallProgress.on_cancel();
	});bindButton($(".js-ms-install_progress__done_install"),function(e,el) {
		blockInstallProgress.on_done();
	});bindButton($(".js-ms-install_progress__done2_install"),function(e,el) {
		blockInstallProgress.on_done();
	});






	bindButton($(".js-ms_open_minedir"),function(e,el) {
        servManager.openDir();
	});bindButton($(".js-ms_open_vk"),function(e,el) {
		AHK.open_vk()
	});bindButton($(".js-ms_open_techsupport"),function(e,el) {
        servManager.openUrl("https://mc-monitoring.info/feedback");
	});
	bindButton($(".js-ms_refresh"),function(e,el) {
        servManager.acceptFilters();
	});

    bindButton($(".js-ms_favourite_button"), function (e, el) {
        
        servManager.inFavorite(select);
        
        
	});
	bindButton($(".js-ms_search_button"),function(e,el) {
		
	});
	$('.js-ms_search_servers').keypress(function(e){
        if (e.keyCode == 13)
            servManager.serchServer($('.js-ms_search_servers').val());
	});










}



const requestAPI = {
	version:"",
	search:"",
	page:1,
	type:"",minigame:"",favourite:"",
	timer:"",

	lastPage:0,
	reset: function(name) {
		if(name)
			return this[name]="";
		this.version=""
		,this.search=""
		,this.page=1
		,this.type=""
		,this.minigame=""
	},
	set: function(name,val) {
		if(!name)
			return false
		return this[name]=val;
	},
	get: function() {
		clearTimeout(this.timer);
		var o=AHK.getServers(this._getFilters());
		//this.timerit();
		this.lastPage=o.last_page
		return o;
	},
	next: function() {
		if(this.page>=this.lastPage)
			return 0
		this.page++;
		clearTimeout(this.timer);
		var o=AHK.getServers(this._getFilters());
			
		//this.timerit();
		return o
	},
	isLastPage: function() {
		if(!this.lastPage)
			return 0
		if(this.page>=this.lastPage)
			return 1
		return 0
	},
	timerit: function() {
		var _this=this;
		this.timer=setTimeout(function() {
			_this.disableTimer();
			getServers(1);
		},5*60*1000) //5mins
	},
	disableTimer: function() {
		clearTimeout(this.timer);
		this.timer=0;
	},
	_getFilters: function() {
		return {version:this.version
				,search:this.search
				,page:this.page

				,type:this.type
				,minigame:this.minigame
				,favourite:this.favourite}
	}
}

function getServers(bHiddenUI) {
	if(!bHiddenUI)
		uiLoader.show()

	requestAPI.set('search',$('.js-ms_search_servers').val());


	blockServers.block(1);
	var i=0,n=0,servers,list=[];
	requestAPI.lastPage=0;
	requestAPI.set('page',1);

	blockServers.clear();
	while(i<150 && !requestAPI.isLastPage()) {
		++n
		servers=i?requestAPI.next():requestAPI.get()
		try {
			i+=servers.data.length
		} catch(e) {
			break
		} if(n==1) {
			blockServers.add(servers.data)
			continue
		} list.push(servers)
	} for (var i=0; i < list.length; i++) {
		blockServers.add(list[i].data)
	}
			if(!bHiddenUI)
				uiLoader.hide();

	blockServers.block(0);

	return 1
} function getServersNext() {
	if(requestAPI.isLastPage())
		return 0
	uiLoader.show()

	var servers=requestAPI.next();
	blockServers.add(servers.data);

	uiLoader.hide();
	return 1
}


function getAccounts() {
    return 1;
}

function getSettings() {
	settingsManager.set(AHK.getSettings());
	return 1
}







function on_likeserver(id) {
	return AHK.likeServer(id)
}

function on_launchgame(addr, ver) {
    verAndAccManager.setServer(addr);
    verAndAccManager.launch(accManager.name,false);
}



function allloaded()
{
    VerAndAccManager.full();
    return 1;
}















const accManager = {
	name:"",
	init:function() {
		var _this=this;
		bindButton($('.js-ms_myaccount__ddl .ddl__list'),function(ev,e) { //accountmanager ddl
			if(!(e=isParentR(ev.target,"ddl__option")) || e.hasClass("ddl__option--noclick"))
                return
            
			_this.setAccount(e.attr('data-value'));
			_this.on_ddl_select(e.attr('data-value'));
			//_this.on_ddl_select(ev,e[0]);
		});

		bindButton($(".js-ms_show_account_manager"),function(ev,e) {
			accManager.show();
		});bindButton($(".js-ms_myaccount__choose"),function(ev,e) {
			accManager.on_choose();
		});

		bindButton($(".js-ms_myaccount__create"),function(ev,e) {
			accManager.on_create(ev,e);
		});bindButton($(".js-ms_myaccount__edit"),function(ev,e) {
			accManager.on_edit();
		});bindButton($(".js-ms_myaccount__delete"),function(ev,e) {
			accManager.on_delete();
		});


		bindButton($(".js-ms_myaccount__createdone"),function(ev,e) {
			accManager.on_createdone();
		});bindButton($(".js-ms_myaccount__editdone"),function(ev,e) {
			accManager.on_editdone();
		});

		bindButton($(".js-ms_myaccount__hide"),function(ev,e) {
			accManager.hide();
		});bindButton($(".js-ms_myaccount__button_tab"),function(ev,e) {
			accManager.tab(e);
        });
        $('.js-ms_myaccount__delete').addClass('hidden');
	},
	setAccount: function(nick) {
		var o=$('.js-ms_myaccount__ddl');
		for (var i = o.length - 1; i >= 0; i--)
			o[i].ddl.select(nick);
        this.name = nick;
       // alert('seracc');
      //  alert(nick);
		$('.js-ms_myaccount__choose').removeClass('hidden');
		//$('.js-ms_myaccount__edit').removeClass('hidden');
        if ($('.js-ms_myaccount__ddl .ddl__list').length >= 2) {
            $('.js-ms_myaccount__delete').removeClass('hidden');
        }
		
	},


	show: function() {
		$(".myaccount").parent().removeClass("hidden");
		uiShadow.show();
	},
	hide: function() {
		$(".myaccount").parent().addClass("hidden");
		uiShadow.hide();
	},
	tab: function(e) {
		$(e).parent().children().removeClass('nav-button--active');
		$(e).toggleClass('nav-button--active');
	},
	clear: function() {
		$('.js-ms_myaccount__ddl .ddl__option:not(.js-nodelete)').remove();
	},
	add: function(nick) {
		$('.js-ms_myaccount__ddl .ddl__list').append(this._createItem(nick));

		var e=$('.js-ms_myaccount__ddl .ddl__option.js-nodelete');
		while(1) {
			if(!e.next().length)
				break
			e.next().insertBefore(e);
		}
	},
	_createItem: function(nick) {
		var e_opt=document.createElement('div');
		e_opt.className='ddl__option';
		e_opt.setAttribute("data-value",nick);
			/* DDL__TEXT */
			var e_nick=document.createElement('i');
			e_nick.className='ddl__text';
			e_nick.innerHTML=nick;
			e_opt.appendChild(e_nick);
			/* DDL__TEXT */
		return e_opt
	},






	on_choose: function(ev,e) {
		this.setAccount(this.name);
		this.hide();
        g_selectedNickname = this.name;
       
		//AHK.setChoosedAccount(g_selectedNickname);
	},



	on_create: function(ev,e) {
       
        if (!isTrustEvent(ev))
			return
		$('.js-ms_myaccount__createdone').removeClass('hidden');
		$('.js-ms_myaccount__editdone').addClass('hidden');
	},
	on_edit: function() {
		$('.js-ms_myaccount__createdone').addClass('hidden');
		//$('.js-ms_myaccount__editdone').removeClass('hidden');
		$('.js-ms_myaccount__button_tab')[1].click();
	},
	on_ddl_select: function(name) {
		
		this.name=name;
		g_selectedNickname=this.name;
        this.setAccount(name);
       // alert('dllselectracc');
      //  alert(name);
		$('.js-ms_myaccount__choose').removeClass('hidden');
		//$('.js-ms_myaccount__edit').removeClass('hidden');
        if ($('.js-ms_myaccount__ddl .ddl__list').length >= 2) {
            $('.js-ms_myaccount__delete').removeClass('hidden');
        }
	},




	on_createdone: function() {
		//AHK.newaccount(this.getWrittenName());
        if (this.getWrittenName().length >= 4) {
            verAndAccManager.addAccount(this.getWrittenName());
            this.setAccount(this.getWrittenName());
            this.on_ddl_select(this.getWrittenName());
            this.setWrittenName('');

            $('.js-ms_myaccount__new').removeClass('hidden');
            $('.js-ms_myaccount__button_tab')[0].click();
            $('.js-ms_myaccount__done').addClass('hidden');

            //getAccounts();
        }
	},
	on_editdone: function() {
		//AHK.editaccount(this.name,this.getWrittenName());
        verAndAccManager.deleteUser(g_selectedNickname);

		$('.js-ms_myaccount__done').removeClass('hidden');
		$('.js-ms_myaccount__new').addClass('hidden');
		$('.js-ms_myaccount__button_tab')[0].click();


		$('.js-ms_myaccount__ddl .ddl__placeholder')[0].innerHTML='none';
		
        
		if(this.name=g_selectedNickname)
			this.setAccount(this.getWrittenName());
	},
	on_delete: function() {
		$('.js-ms_myaccount__choose').addClass('hidden');
		$('.js-ms_myaccount__edit').addClass('hidden');
		$('.js-ms_myaccount__delete').addClass('hidden');

		
        
        verAndAccManager.deleteUser(this.name);
		if(this.name=g_selectedNickname)
			this.setAccount('');
		this.name="";

		
		$('.js-ms_myaccount__ddl .ddl__placeholder')[0].innerHTML='none';
		//getAccounts();
	},





	getWrittenName:function() {
		return $('.js-ms_myaccount__nickname').val()
	},
	setWrittenName:function(v) {
		return $('.js-ms_myaccount__nickname').val(v)
	}




}


const settingsManager = {
	bInit:0,
	init: function() {
		this.bInit=1
		var _this=this;
		bindUnclickEvent($(".settings_manager"),function(eve,e) {
			_this.hide();
		});

		$('.js-ms_setmanager_mem').focusout(function() {
			_this.setMem($(".js-ms_setmanager_mem").val());
		});


		bindButton($('.js-ms_setmanager_save'),function(ev,e) {
			_this.on_save();
			_this.hide();
		});bindButton($('.js-ms_setmanager_default'),function(ev,e) {
			_this.on_default();
		});bindButton($('.js-ms_setmanager_close'),function(ev,e) {
			_this.hide();
		});
		this.memSlider()
	},
	memSlider:function() {
		$(".js-ms_setmanager_slider").slider({
			step: 256,
			min: 512,
			max: 3072,
			values: 0,

			slide: function (event, ui) {
				$(".js-ms_setmanager_mem").val(ui.value);
			}
		}).slider('pips', {
			//first: 512,
			//last: 3072,

			// labels: [512,768,1024,1280,1536,1792,2048,2304,2560,2816,3072],
			rest: "label",
			step: 2
			// prefix: "",
			//suffix: ""
		});
	},
	set: function(settings) {
		this.setMem(settings.mem)
		,this.setWidth(settings.width)
		,this.setHeight(settings.height);
	},

	on_default: function() {
		this.setMem(1024)
		,this.setWidth(925)
		,this.setHeight(530);
	},

	on_save: function() {
        
        verAndAccManager.setSettings(this.getWidth(), this.getHeight(), this.getMem());
        
	},


	setWidth:function(v) {
		return $(".js-ms_setmanager_res_width").val(v);
	},
	setHeight:function(v) {
		return $(".js-ms_setmanager_res_height").val(v);
	},
	setMem:function(v) {
		$(".js-ms_setmanager_slider").slider('value', v)
		$(".js-ms_setmanager_mem").val($(".js-ms_setmanager_slider").slider('value'));
	},

	getWidth:function() {
		return $(".js-ms_setmanager_res_width").val();
	},
	getHeight:function() {
		return $(".js-ms_setmanager_res_height").val();
	},
	getMem:function() {
		return $(".js-ms_setmanager_slider").slider('value')
	},




	show: function() {
		$(".settings_manager").parent().removeClass("hidden");
		uiShadow.show();

		
		$(".settings_manager").addClass('active');
		return false; //block next click-events (once unclick event)
	},
	hide: function() {
		$(".settings_manager").parent().addClass("hidden");
		uiShadow.hide();

		$(".settings_manager").removeClass('active');
	}
}



// verManager.set({installed:[["title","value"]],notinstalled:[["title2","value2"]]})
const verManager = {
	bInit:0,
	version:'',
	init: function() {
		this.bInit=1
		var _this=this;
		bindUnclickEvent($(".ver_manager"),function(eve,e) {
			_this.hide();
		});
		bindButton($('.js-ms_installed_versions .ddl__list'),function(ev,e) { //accountmanager ddl
			if(!(e=isParentR(ev.target,"ddl__option")) || e.hasClass("ddl__option--noclick"))
                return
            verAndAccManager.selectVersion(e.attr('data-value'));
			//AHK.setChoosedVersion(e.attr('data-value'));
			_this.on_ddl_select(ev,e[0]);
		});
	},
	show: function() {
		$(".ver_manager").parent().removeClass("hidden");
		uiShadow.show();

		
		$(".ver_manager").addClass('active');
		return false; //block next click-events (once unclick event)
	},
	hide: function() {
		$(".ver_manager").parent().addClass("hidden");
		uiShadow.hide();

		$(".ver_manager").removeClass('active');
	},
	clear: function() {
		$('.ver_manager .body .table').find('.item:not(.js-nodelete)').remove();
    },

	setVersion: function(version) {
		var o=$('.js-ms_installed_versions');
		for (var i = o.length - 1; i >= 0; i--)
			o[i].ddl.select(version);
        this.version = version;
        
       
    },
    
    checkInstall: function(version) {
        var o = $('.js-ms_installed_versions');
        var is = 0;
      
        for (var i = o.length - 1; i >= 0; i--)
        {
            //alert(o[i].ddl__option);
            if (o[i] == version)
                is = 1;
        }
        return is;

     },
	set: function(obj) {
		this.clear();
		var e,_this=this;
		var installed=obj.installed;

		$('.js-ms_installed_versions .ddl__list').find('.ddl__option:not(.js-nodelete)').remove();

		for(var i = installed.length - 1; i >= 0; i--)
			$('.js-ms_show_ver_manager').before(e=_createElem(makeTitle(installed[i]),installed[i]))
			,bindButton(e, function(foo,el) {
				_this.on_click($('.js-ms_vermanager_installed').parent().find('[data-value="'+$(el).attr('data-value')+'"]'));
			});

		for(var i = 0; i < installed.length; i++)
			$('.js-ms_vermanager_installed').after(e=this._createItem(makeTitle(installed[i]),installed[i]))
			,bindButton(e, function(foo,el) {_this.on_click(el);});

		var notinstalled=obj.notinstalled;
		for(var i = notinstalled.length - 1; i >= 0; i--)
			$('.js-ms_vermanager_notinstalled').after(e=this._createItem(makeTitle(notinstalled[i]),notinstalled[i])),bindButton(e, function(foo,el) {
				_this.on_click(el);
			});
		this.setVersion(this.version);


		function _createElem(title,value) {
			var e_opt=document.createElement('div');
			e_opt.className='ddl__option';
			e_opt.setAttribute("data-value",value);
				/* DDL__TEXT */
				var e_title=document.createElement('h1');
				e_title.className='ddl__text';
				e_title.innerHTML=title;
				e_opt.appendChild(e_title);
				/* DDL__TEXT */
			return e_opt
		}
		function makeTitle(ver) {
			
            return ver;
		}
	},
	getSelectedEl: function() {
		return $('.ver_manager .body .table .item--active')[0]
	},
	getSelectedVer: function() {
		return $(this.getSelectedEl()).attr("data-value")
	},
	on_install: function() {
        this.hideButtons();
        this.getSelectedVer()
        verAndAccManager.selectVersion(this.getSelectedVer());
        verManager.hide();
        verAndAccManager.launch(accManager.name, true);
      
	},
	on_reinstall: function() {
        this.hideButtons();
        verManager.hide();
        verAndAccManager.deletever(this.getSelectedVer());
        verAndAccManager.launch(accManager.name, true);
        
	},
	on_delete: function() {
        this.hideButtons();
       
        verAndAccManager.deletever(this.getSelectedVer());
	},

	hideButtons: function() {
		$('#btn_vermanager__install').addClass('hidden')
		$('#btn_vermanager__uninstall').addClass('hidden')
		$('#btn_vermanager__reinstall').addClass('hidden')
	},
	on_update: function() {
		this.hideButtons();
		$(this.getSelectedEl()).attr("data-value")
	},



	on_click: function(el) {
		$(el).parent().children().removeClass('item--active');
		$(el).addClass('item--active');
		$(el).attr('data-value');
        
        if (verAndAccManager.isInstalled($(el).attr('data-value')) == 0) {

            $('#btn_vermanager__install').removeClass('hidden')
            $('#btn_vermanager__uninstall').addClass('hidden')
            $('#btn_vermanager__reinstall').addClass('hidden')
        }
        else
        {
            $('#btn_vermanager__install').addClass('hidden')
            $('#btn_vermanager__reinstall').removeClass('hidden')


            $('#btn_vermanager__uninstall').removeClass('hidden')
        }
        
		
			
	},
	_createItem: function(name,value) {
		var e_item=document.createElement('div');
		e_item.className='item';
		e_item.classList.add("item--","item--colored")
		e_item.setAttribute("data-value",value);

			/* ITEM__TITLE */
			var title=document.createElement('h1');
			title.className='title';
			title.innerHTML=name;
			e_item.appendChild(title);
			/* ITEM__TITLE */
		return e_item
	}
}



const blockFilters = {
	clear: function() {
		$("#cnt-filters_main").children(":not(.js-nodelete)").remove();
		$("#cnt-filters_minigames").children().remove();
	},
	add: function(block,filters) {
		var parent,e;
		if(block=="main")
			parent=$("#cnt-filters_main")[0];
		else if(block=="minigames")
			parent=$("#cnt-filters_minigames")[0];
		if(!parent)
			return 0
		for (var i = 0; i < filters.length; i++)
			parent.appendChild(this._createItem(filters[i]["name"],filters[i]["slug"],block))
		return 1
	},
	bind: function() {
		var _this=this;
		//bindButton($("#cnt-filters_main .item"),function(e,el){_this.on_click(el);});
		//bindButton($("#cnt-filters_minigames .item"),function(e,el){_this.on_click(el);});
		bindButton($(".filters .item"),function(e,el){_this.on_click(el);});
	},
	on_click: function(e) {
		if($(e).hasClass('item--active'))
			return
		// $('#cnt-filters_main').children().removeClass('item--active');
		// $('#cnt-filters_minigames').children().removeClass('item--active');
		$('.filters .item').removeClass('item--active');
		$(e).toggleClass('item--active');
        if ((filter = e.getAttribute("data-value")) == "all")
            filter = "";

		
        
        if ((filterBlock = e.getAttribute("data-filter")) == "main") {
            servManager.setmainfilter(filter);
            //requestAPI.set('type',filter);
        }
        else {
            servManager.setminifilter(filter);
        }

		//requestAPI.set('page',1);
		//getServers();
	},
	_createItem: function(title,filter,block) {
		var div=document.createElement('div');
		div.className='item';
		div.setAttribute("data-value",filter);
		div.setAttribute("data-filter",block);

		var h1=document.createElement('h1');
		h1.className='text';
		h1.innerHTML=title;

		div.appendChild(h1);
		return div
	}
}


const blockVersions = { 
	clear: function() {
		$("#cnt-versions").children(":not(.js-nodelete)").remove();
	},
	add: function(versions) {
		var parent=$("#cnt-versions"),e;
		for(var i = 0; i < versions.length; i++)
			parent.children().last().after(e=this._createItem(versions[i]));
		return 1
	},
	bind: function(e) {
		var _this=this;
		bindButton($("#cnt-versions .button"),function(e,el){_this.on_click(el);});
	},
	on_click: function(e) {
		if($(e).hasClass('button--active'))
			return
		$('#cnt-versions').children().removeClass('button--active');
		$(e).toggleClass('button--active');
		if((ver=e.getAttribute("data-value"))=="all")
            ver = ""
        servManager.setVersion(ver);
		//requestAPI.reset('favourite');
		//requestAPI.set('version',ver)
		//requestAPI.set('page',1)
		//getServers();
	},
	_createItem: function(ver) {
		var div=document.createElement('div');
		div.className='button';
		div.setAttribute("data-value",ver);

		var h1=document.createElement('h1');
		h1.className='button__text';
		h1.innerHTML=ver;

		div.appendChild(h1);
        return div;
	}
}


const uiLoader = {
	show: function() {
		//$(".emptyfield").removeClass("hidden");
		//return
		$(".loader2").parent().removeClass("hidden");
		uiShadow.show();
	},
	hide: function() {
		//$(".emptyfield").addClass("hidden");
		//return
		$(".loader2").parent().addClass("hidden");
		uiShadow.hide();
	},
}

const uiShadow = {
	iTick:0,
	show: function() {
		$(".window .shadow").removeClass("hidden");
		//this.iTick++
	},
	hide: function() {
		//if(--this.iTick)
		//	return
		$(".window .shadow").addClass("hidden");
	},
}


























// blockServers.add([{"addr":"mc.papa-craft.ru:25565","buy_color_url":"https:\/\/mc-monitoring.info\/buy\/color?server_id=6510","buy_score_url":"https:\/\/mc-monitoring.info\/buy\/votes?server_id=6510","color":"","icon_src":"https:\/\/mc-monitoring.info\/img\/icons\/0wHITRZYpf.png","id":"6510","name":"Papa Craft","now_online":"1","online":"17","rating":"7","score":"100","short_desc":"\u0411\u0438\u0442\u0432\u0430\u041A\u043B\u0430\u043D\u043E\u0432,\u0411\u0438\u043B\u0434\u0411\u0430\u0442\u043B,\u0421\u043A\u0430\u0439\u0431\u043B\u043E\u043A,\u041C\u043E\u0431\u0410\u0440\u0435\u043D\u0430,\u0421\u043A\u0430\u0439\u0412\u0430\u0440\u0441,\u041A\u0440\u0443\u0442\u043E\u0435 \u0412\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435,\u041E\u0440\u0443\u0436\u0438\u0435,\u041F\u0438\u0442\u043E\u043C\u0446\u044B","site":"http:\/\/papa-craft.ru","slots":"2018","url":"https:\/\/mc-monitoring.info\/server\/6510","version":"1.12.2","vote_url":"https:\/\/mc-monitoring.info\/server\/vote\/6510"}])

const blockServers = {
	lastNum:0,
	bInit:0,
	init: function() {
		var _this=this;
		if(this.bInit)
			return 1
		this.bInit=1;
		$('#cnt-servers').parent().parent().scroll(function(ev) {
			if(_this.bBlock)
				return false;
			return _this.display.on_scroll(ev);
		});
	},
	block: function(v) {
		this.bBlock=v;
	},
	clear: function() {
		this.lastNum=0;
		this.display.clear();
	},
	add: function(servers) {
		this.init()
		if(!servers || !servers.length)
			return
		for(var i = 0; i < servers.length; i++) {
			let obj=servers[i]
			this.display.addItem(this._createItem(++this.lastNum,obj));
		} return 1
	},
	display: {
		items:[],
		itemsN:0,


		maxItems:150,
		maxItemsTop:20,
		maxItemsDown:20,
		shownItems:0,
		lastItem:0,

		bBlockScroll:0,
		addItem:function(item) {
			this.items.push(item);
			this.itemsN++
			if(this.shownItems<this.maxItems)
				this.shownItems++,this.add(this.shownItems-1),this.lastItem++
		},
        on_scroll: function (ev) {
          
			if(this.bBlockScroll) {
				ev.preventDefault();
				ev.stopPropagation();
				return false;
			} var ej_scroll=$('#cnt-servers').parent().parent()
				, ej_cnt=$('#cnt-servers')
			var offset=ej_scroll.scrollTop()
			,visibleArea=ej_scroll.height();

			var itemHeight=ej_cnt.height()/this.shownItems;
			//var curVisibleItem=this.shownItems-(ej_cnt.height()/itemHeight-(offset)/itemHeight);
			var posTop =(offset)/ej_cnt.height()*100;
			var posDown=100-((offset+visibleArea)/ej_cnt.height()*100);



			this.bBlockScroll=1;

            var n = 20, scrollTick;
            if (this.lastItem+20 >= (servManager.getPage()-1)*50)
            {
                servManager.getServerInfo();
            }
			while(1) {
               
                if (posTop < this.maxItemsTop) {
                    if (this.lastItem - this.shownItems <= 0)
                        break;

					scrollTick=offset;
					this.unload(n,'down'); //Отгружаем элементы в конце списка
					scrollTick+=this.load(n,'top');  //Подгружаем элементы в начало списка
                    ej_cnt.parent().parent().scrollTop(6000);
                    //$('.js-ms_url_adv_server .button__text').html(this.shownItems + "<" + this.lastItem);
                } else if (posDown < this.maxItemsDown) {
                    if (this.itemsN - this.lastItem <= 0) //нечего подгружать
                        break;
					if(this.lastItem+n>this.itemsN)
						if(!getServersNext())
							n=this.itemsN-this.lastItem;

                    //$('.js-ms_url_adv_server .button__text').html(this.shownItems+"<"+this.lastItem);
					
					//log(this.itemsN+"<="+this.lastItem)
					if(n<1)
						break
					scrollTick=offset;
					scrollTick-=this.unload(n,'top') //Отгружаем элементы в начале списка
					//return 1
					this.load(n,'down');  //Подгружаем элементы в конец списка
				} if(scrollTick && scrollTick!=ej_scroll.scrollTop()) {
					//log("scroll ["+scrollTick+"/"+ej_scroll.scrollTop()+"]")
					ej_scroll.scrollTop(scrollTick)
				}
				break
			}
				//ej_scroll.scroll(height);
				//$('.js-ms_url_adv_server .button__text').html(height);
				//$('.js-ms_url_adv_server .button__text').html(g_filters.page);
			this.bBlockScroll=0;
			return true;
			//ev.preventDefault();
		},

		//Отгрузить элементы
		// n - сколько отгружать
		// wh - где отгружать (where) [top,down]
		// returns: высота отгруженных элементов
		unload:function(n,wh) {
			var out=0

			var children=$('#cnt-servers').children();
			if(wh=='top')
				offset=0;
			else offset=children.length-n;
			n=children.length<n?children.length:n
			for (var i = n-1; i >= 0; i--)
				out+=$(children[(offset+i)]).height()
				,children[(offset+i)].remove()

			this.shownItems-=n;
			return out
		},

		//Подгрузить элементы
		// n - сколько подгружать
		// wh - где отгружать (where) [top,down]
		load:function(n,wh) {
			var IsBefore=0,ej=$('#cnt-servers').children(); //ej - element jquery
			if(wh=='top')
				IsBefore=1
				,ej=ej.first()
				,offset=this.lastItem-this.maxItems-n

				,this.lastItem-=n;
			else 
				ej=ej.last()
				,offset=this.lastItem

				,this.lastItem+=n;


			if(offset<0)
				offset=0;
			if(this.lastItem<0)
				this.lastItem=0;


			out=0;
			for (var i = n; i >= 0; i--) {
				if(IsBefore) //Подгружаем в начало списка
					ej=$(ej.before(this.items[(offset+n-i)]));
				else ej.after(this.items[(offset+i)]);
				out+=ej.height()
			} this.shownItems+=n;
			return out
		},

		add:function(n) {
			var parent=$("#cnt-servers")[0];
			$(parent).append(this.items[n]);
		},

		clear:function() {
			this.bBlockScroll=1;
			//$('#cnt-servers').parent().parent().scrollTop(0);
			for (var i = 0; i < this.items.length; i++) {
				try {
					//$(this.items[i]).remove()
					//log($(this.items[i]))
					//$(this.items[i])[0].remove()
					$(this.items[i])[0].innerHTML='';
					$(this.items[i])[0].parentNode.removeChild($(this.items[i])[0])
					//log($(this.items[i]))
				} catch(e) {
					//log(e)

				}
			} $("#cnt-servers").children(":not(.js-nodelete)").remove();
			this.items=[],this.itemsN=0;

			this.shownItems=0,this.lastItem=0;
			this.bBlockScroll=0;
		}
	},


















    on_likebutton: function (e, e_item) {
        //alert(e.getAttribute('data-serverid'));
        servManager.addToFav(e.getAttribute('data-serverid'));
		if(on_likeserver(e.getAttribute('data-serverid'))==1)
			$(e_item).addClass('item--favourite')
		else $(e_item).removeClass('item--favourite')
	},
	on_playbutton: function(e,ver) {
		on_launchgame(e.getAttribute('data-addr'),ver);
	},




	_createItem: function(num,obj) {
		var yo=yo
			,addr=obj.addr
			,color=obj.color

			,url=obj.icon_src
			,title=obj.name
			,desc=obj.short_desc
			,voices=obj.rating
			,points=obj.score
			,online=obj.online+" из "+obj.slots
			,version=obj.version
			,color=obj.color
			,favourite=obj.favourite;

		var e_item=document.createElement('div');
		e_item.className='item';
		if(color && color!='null')
			e_item.classList.add("item--type"+color.replace("cl-",""))
			,e_item.classList.add("item--colored");
		if(favourite)
			e_item.classList.add("item--favourite")
		// e_item.setAttribute("data-filter",filter); TO_EDIT

			/* ITEM__NUM */
			var item__num=document.createElement('h1');
			item__num.className='item__num';
			item__num.innerHTML=num;
			e_item.appendChild(item__num);

			/* ITEM__ICON */
			var e_img=document.createElement('img');
			e_img.className='item__icon';
			e_img.src=(url.length>10?url:"");
			e_item.appendChild(e_img);
			/* ITEM__ICON */


			/* ITEM__BODY */
			var e_body=document.createElement('div');
			e_body.className='item__body';

				/* ITEM__TITLE */
				var e_title=document.createElement('h1');
				e_title.className='item__title';
				e_title.innerHTML=title;
				e_body.appendChild(e_title);
				/* ITEM__TITLE */

				/* ITEM__DESC */
				var e_desc=document.createElement('h1');
				e_desc.className='item__desc';
				e_desc.innerHTML=desc;
				e_body.appendChild(e_desc);
				/* ITEM__DESC */

				/* ITEM__CONTROLS */
				e_body.appendChild(this._createControls(points,voices,obj));
				/* ITEM__CONTROLS */
			/* ITEM__BODY */
			e_item.appendChild(e_body);


			/* ITEM_INFO */
			var e_info=document.createElement('div');
			e_info.className='item__info';
				/* ITEM__SERVER_STATUS */
				var e_ss=document.createElement('div');
				e_ss.className='item__server_status';

					var e_online=document.createElement('h1');
					e_online.className='item__online';
					e_online.innerHTML=online;
					e_ss.appendChild(e_online);

					var e_version=document.createElement('h1');
					e_version.className='item__version';
					e_version.innerHTML=version;
					e_ss.appendChild(e_version);
				/* ITEM__SERVER_STATUS */
				e_info.appendChild(e_ss);

				/* buttons */
				var e_bs=document.createElement('div');
				e_bs.className='buttons';
					/* LIKEBUTTON */
					var e_lb=document.createElement('div');
					e_lb.className='likebutton';
					e_lb.setAttribute('data-serverid',obj.id?obj.id:null);
						var e_pbi=document.createElement('span');
						e_pbi.className='fa fa-heart';
						e_lb.appendChild(e_pbi);
					/* LIKEBUTTON */
					e_bs.appendChild(e_lb);

					/* PLAYBUTTON */
					var e_pb=document.createElement('div');
					e_pb.className='playbutton';
					e_pb.setAttribute('data-addr',addr);
						var e_pbi=document.createElement('span');
						e_pbi.className='playbutton__icon icon icon--i_play';
						e_pb.appendChild(e_pbi);

						var e_txt=document.createElement('h1');
						e_txt.className='playbutton__text';
						e_txt.innerHTML="Играть";
						e_pb.appendChild(e_txt);
					/* PLAYBUTTON */
					e_bs.appendChild(e_pb);
				/* buttons */
				e_info.appendChild(e_bs);
				var _this=this;
				bindButton(e_lb,function(el,e) {_this.on_likebutton(e,e_item)});
				bindButton(e_pb,function(el,e) {_this.on_playbutton(e,version)});
			/* ITEM_INFO */
			e_item.appendChild(e_info);


		return e_item
	},
	_createControls: function(points,voices,obj) {
		/* ITEM__CONTROLS */
		var e_controls=document.createElement('div');
		e_controls.className='item__controls';

			/* ITEM__POINTS */
			var e_points=document.createElement('h1');
			e_points.className='item__points';
			e_points.innerHTML=points+" баллов";
			e_controls.appendChild(e_points);
			/* ITEM__POINTS */

			/* ITEM__BUTTON--RED */
			if(obj.buy_score_url)
				e_controls.appendChild(this._createButton('type1',obj.buy_score_url));
			/* ITEM__BUTTON--RED */
			/* ITEM__BUTTON--BLUE */
			if(obj.buy_color_url)
				e_controls.appendChild(this._createButton('type2',obj.buy_color_url));
			/* ITEM__BUTTON--BLUE */

			/* ITEM__POINTS */
			var e_voices=document.createElement('h1');
			e_voices.className='item__voices';
			e_voices.innerHTML=voices+" голосов";
			e_controls.appendChild(e_voices);
			/* ITEM__POINTS */

			/* ITEM__BUTTON--GREEN */
			if(obj.vote_url) //ГОЛОСА
				e_controls.appendChild(this._createButton('type3',obj.vote_url));
			/* ITEM__BUTTON--GREEN */
			/* ITEM__BUTTON--YELLOW */
			if(obj.site)
				e_controls.appendChild(this._createButton('type4',obj.site));
			/* ITEM__BUTTON--YELLOW */

		/* ITEM__CONTROLS */
		return e_controls;
	},
	_createButton: function(type,url) {
		var e_btn=document.createElement('div');
		e_btn.className='item__button';
		e_btn.setAttribute("data-value",url)

		var text,cl_icon;
		if(type=='type1')
			text='поднять в топ',cl_icon='icon icon--i_star';
		else if(type=='type2')
			text='выделить цветом',cl_icon='icon icon--i_paint';
		else if(type=='type3')
			text='проголосовать',cl_icon='icon icon--i_like';
		else if(type=='type4')
			text='купить донат',cl_icon='icon icon--i_dollar';
		else type=0;
		if(type)
			e_btn.classList.add('item__button--'+type)
		if(cl_icon) {
			var e_icon=document.createElement('span');
			e_icon.className='button__icon '+cl_icon;
			e_btn.appendChild(e_icon);
		} if(text) {
			var e_h1=document.createElement('h1');
			e_h1.className='button__text';
			e_h1.innerHTML=text;
			e_btn.appendChild(e_h1);
		} bindButton($(e_btn),function(e,el) {
			servManager.openUrl(el.getAttribute("data-value"));
		}); return e_btn
	}
}

/*



*/










const blockInstallProgress = {
	set: function(title,perc) {
		$('.install_progress .title').html(title);
		$('.install_progress .progress').css("width",perc+"%");
		$('.install_progress .perc').html(perc+"%");
		return perc;
	},
	on_cancel: function() {
		if(!AHK.installation('cancel'))
			return 0;
		this.hide();
	},
	on_done: function() {
		this.hide();
	},
	hide: function() {
		$(".install_progress").parent().addClass("hidden");
		uiShadow.hide();
	},
	show: function() {
		$(".install_progress").parent().removeClass("hidden");
		uiShadow.show();

		$('.js-ms-install_progress__cancel_install').removeClass('hidden');
		$('.js-ms-install_progress__done_install').addClass('hidden');
		$('.js-ms-install_progress__done2_install').addClass('hidden');
	},

	complete: function() {
		$('.js-ms-install_progress__cancel_install').addClass('hidden');
		$('.js-ms-install_progress__done_install').removeClass('hidden');
		$('.js-ms-install_progress__done2_install').addClass('hidden');
	},
	cancel: function() {
		$('.js-ms-install_progress__cancel_install').addClass('hidden');
		$('.js-ms-install_progress__done_install').addClass('hidden');
		$('.js-ms-install_progress__done2_install').removeClass('hidden');
	}
}






























































