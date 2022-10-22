-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 
-- 伺服器版本： 10.1.38-MariaDB
-- PHP 版本： 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `pc`
--

-- --------------------------------------------------------

--
-- 資料表結構 `agent`
--

CREATE TABLE `agent` (
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `Agent_name` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `agent`
--

INSERT INTO `agent` (`brand`, `Agent_name`) VALUES
('AMD', '精技'),
('EVGA', 'EVGA'),
('intel', '聯強'),
('Montech', 'Montech'),
('NZXT', '立光'),
('Seagate', '聯強'),
('Toshiba', '富基電通'),
('UMAX', '建達'),
('WD', '捷元'),
('三星', '捷元'),
('全漢', '捷元'),
('利民', '日森興業'),
('微星', '微星'),
('技嘉', '技嘉'),
('振華', '振華'),
('海韻', '海韻'),
('美光', '捷元'),
('華碩', '華碩'),
('貓頭鷹', '佳多力'),
('酷碼', '騰網科技'),
('金士頓', '建達');

-- --------------------------------------------------------

--
-- 資料表結構 `case_brand`
--

CREATE TABLE `case_brand` (
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `case_brand`
--

INSERT INTO `case_brand` (`brand`) VALUES
('Montech'),
('NZXT'),
('全漢');

-- --------------------------------------------------------

--
-- 資料表結構 `company`
--

CREATE TABLE `company` (
  `cnumber` int(10) NOT NULL,
  `companyname` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `Agent_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `telephone` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `web` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 傾印資料表的資料 `company`
--

INSERT INTO `company` (`cnumber`, `companyname`, `Agent_name`, `telephone`, `web`) VALUES
(1, '捷聯電子(股)公司／冠捷集團', '捷聯', '02-82261668', 'http://www.TPVAOC.COM'),
(2, '台灣明尼達礦業製造股份有限公司', '明尼達', '02-27049011', 'http://www.3m.com.tw'),
(3, '三多利國際有限公司', '三多利', '02-88091833', 'http://www.3more.com.tw'),
(4, '五次方網繹', '五次方', '02-25958051', 'https://www.twincn.com/item.aspx?no=12951052'),
(5, '大訊科技股份有限公司', '大訊', '03-3759000', 'http://www.ablecom.com.tw'),
(6, '友旺科技股份有限公司', '友旺', '03-5398081', 'http://www.aboway.com.tw/'),
(7, '信億科技股份有限公司', '信億', '02-85122290', 'http://www.acard.com'),
(8, '宏碁雲端技術服務股份有限公司', '宏碁', '02-27195000', 'https://www.aceraeb.com/'),
(9, '歐沅股份有限公司', '歐沅', '02-26512782', 'http://tw.acrossmedia.com/'),
(10, '哲固資訊科技股份有限公司', '哲固', '03-3135577', 'http://www.acula.com'),
(11, '凌華科技(股)公司', '凌華', '02-82265877', 'http://www.adlinktech.com'),
(12, '永洋科技股份有限公司', '永洋', '06-5058026', 'www.amit.com.tw'),
(13, '研華股份有限公司', '研華', '02-22182424', 'http://www.advantech.com'),
(14, '其陽科技股份有限公司', '其陽', '02-86926677', 'http://www.aewin.com.tw'),
(15, '光鈦國際科技有限公司', '光鈦', '03-3128833', 'http://www.drboard.com.tw'),
(16, '明泰科技股份有限公司', '明泰', '02-82959170', 'http://www.alphanetworks.com'),
(17, '美商安邁科技股份有限公司台灣分公司', '安邁', '02-25168887', 'http://www.ami.com'),
(18, '瑞軒科技', '瑞軒', '02-82280505', 'http://www.amtran.com.tw/'),
(19, '安山電子有限公司', '安山電子', '02-22450358', 'http://www.ansentech.com'),
(20, '建碁(股)公司', '建碁', '02-77101195', 'http://www.aopen.com'),
(21, '兆商(股)公司(建碁負責亞太&大中華區)', '兆商', '06-5832711', 'https://www.iyp.com.tw/065832711'),
(22, '億佳科技有限公司', '億佳', '02-29751021', 'http://www.apass.com.tw'),
(23, '新銳精密(股)公司', '新銳', '03-5772855', 'http://www.apix.com.tw'),
(24, '台灣應用光源股份有限公司', '應用光源', '03-5633588', 'http://www.appliedgreenlight.com'),
(25, '偉聯科技股份有限公司', '偉聯', '04-23599860', 'http://www.agneovo.com'),
(26, '宏正自動科技股份有限公司', '', '', 'http://www.aten.com.tw'),
(27, '華騰國際科技股份有限公司', '', '', 'http://www.atpinc.com'),
(28, '友達光電股份有限公司', '友達', '', 'http://www.auo.com'),
(29, '合邦電子(股)公司', '', '', 'http://www.avid.com.tw'),
(30, '浤鉅科技股份有限公司', '', '', 'http://www.avlinking.com'),
(31, '蕉點行銷有限公司', '', '', 'http://www.bananafocus.com'),
(32, '地球種子應用科技有限公司', '', '', 'http://www.benevo.com.tw/'),
(33, '明基電通股份有限公司', '', '', 'http://www.BenQ.com'),
(34, '明基逐鹿股份有限公司', '', '', 'tw.BenQGuru.com'),
(35, '柏昇科技股份有限公司', '', '', 'http://www.bestek.tw'),
(36, '晁碁科技(股)公司', '', '', 'http://www.bizlution.com'),
(37, '藍訊科技股份有限公司', '', '', 'http://www.bluesign.com.tw'),
(38, '博瑞歐股份有限公司', '', '', 'http://www.bravomedia.com.tw'),
(39, '捷鼎科技有限公司', '', '', 'http://www.brilliant-sys.com'),
(40, '錢櫃企業股份有限公司', '', '', 'http://www.cashboxparty.com'),
(41, '鎧應科技股份有限公司', '', '', 'http://www.cayintech.com'),
(42, '瑄品股份有限公司', '', '', ''),
(43, '全達國際股份有限公司', '', '', 'http://www.chander.com'),
(44, '奇寶科技多媒體有限公司', '', '', 'http://www.bctv.com.tw'),
(45, '奇緯光電股份有限公司', '', '', 'http://www.chiefway.com.tw/'),
(46, '中華映管(股)公司', '', '', 'http://www.cptt.com.tw'),
(47, '立光科技國際股份有限公司', '立光', '02 2100 2500', 'https://www.krone.com.tw/'),
(48, '富明數位國際有限公司', '', '', 'http://www.cloudsled.com'),
(49, '揚泰光電股份有限公司', '', '', 'http://www.coretronic.com'),
(50, '中光電系統工程股份有限公司', '', '', 'http://www.coretronic-system.com'),
(51, '玉米數碼股份有限公司', '', '', 'http://www.corndigital.com'),
(52, '宏灃科技股份有限公司', '', '', 'http://www.covia.net'),
(53, '名匠設計室內裝修有限公司', '', '', 'http://www.craftsmen.com.tw/'),
(54, '西柏科技(股)公司', '', '', 'http://www.cypress.com.tw'),
(55, '友訊科技股份有限公司', '', '', 'www.dlink.com'),
(56, '得泰科技(股)公司', '', '', ''),
(57, '台達電子工業股份有限公司', '', '', 'http://www.deltadisplays.com'),
(58, '太極影音股份有限公司', '', '', 'http://www.digimax.com.tw/'),
(59, '碟王科技開發股份有限公司', '', '', 'http://www.sotouch-tech.com'),
(60, '美商定誼科技股份有限公司台灣分公司', '', '', 'http://www.dtresearch.com'),
(61, '光遠科技股份有限公司', '', '', 'http://www.dynascan.com.tw'),
(62, '元太科技工業股份有限公司', '', '', 'http://www.eink.com/'),
(63, '精穗實業', '', '', 'http://www.eagovisiontech.com'),
(64, '怡鑫科技股份有限公司', '', '', 'http://www.ecaftech.com'),
(65, '頤曜數位股份有限公司', '', '', 'http://www.ejump.com.tw'),
(66, '精英電腦股份有限公司', '', '', 'http://www.ecs.com.tw/'),
(67, '揚翔科技股份有限公司', '', '', 'http://www.emw.com.tw'),
(68, '台灣愛普生科技股份有限公司', '', '', 'http://www.epson.com.tw'),
(69, '銪德科技股份有限公司', '', '', 'http://www.etandt.com.tw'),
(70, '長茂科技股份有限公司', '', '', 'http://www.emt.com.tw'),
(71, '恒商企業股份有限公司', '', '', 'http://www.everpark.com.tw'),
(72, '廣迅媒體數位科技有限公司', '', '', 'http://www.extensive-media.com.tw'),
(73, '風尚國際廣告事業有限公司', '', '', 'www.makerhut.com'),
(74, '法亞科技整合行銷股份有限公司', '', '', 'http://www.faya.com.tw'),
(75, '夢蝶股份有限公司', '', '', ''),
(76, '豐禾通訊科技有限公司', '', '', 'http://www.champtron.com'),
(77, '富達立科技股份有限公司', '', '', 'http://www.photoera.com.tw'),
(78, '伍豐科技(股)公司', '', '', 'http://www.firich.com.tw'),
(79, '豐宏科技股份有限公司', '', '', 'www.foho.com.tw'),
(80, '琦景科技股份有限公司', '', '', 'http://www.formosoft.com'),
(81, '亞洲IT商業研究會', '', '', 'http://www.asia-itbiz.com'),
(83, '技酷科技股份有限公司', '', '', 'http://www.gecube.com.tw'),
(84, '技嘉科技股份有限公司', '技嘉', '02-89131377', 'www.gigabyte.com'),
(85, '喬百利科技(股)公司', '', '', 'http://www.giovellitech.com.tw'),
(86, '坤巨資訊股份有限公司', '', '', 'www.gtouch.com'),
(87, '冠騰設計有限公司', '', '', 'http://www.gt-technology.com'),
(88, '倚新科技股份有限公司', '', '', 'www.gxore.com'),
(89, '宏齊科技股份有限公司', '', '', 'http://www.harvatek.com/index.asp?lang=1'),
(90, '精研國際傳播事業有限公司', '', '', 'www.HD.Club.tw'),
(91, '桓基科技股份有限公司', '', '', 'http://www.hgiga.com'),
(92, '高誠科技(股)公司', '', '', 'http://www.highgrade.com.tw'),
(93, '宏鼎互動科技有限公司', '', '', 'www.highnesstech.com'),
(94, '竑立貿易有限公司', '', '', 'http://www.holy7717.com'),
(95, '家系數位科技有限公司', '', '', 'http://www.e-switch.com.tw'),
(96, '鴻海精密工業股份有限公司', '', '', ''),
(97, '鴻鵠國際股份有限公司', '', '', 'http://www.honghutech.com'),
(98, '華雅應用材料股份有限公司', '', '', 'http://www.hyam.com.tw'),
(99, '懷藝電子股份有限公司', '', '', 'http://www.weiya.com.tw'),
(100, '皇耀興業有限公司', '', '', ''),
(101, '綠創科技股份有限公司', '', '', 'http://www.IAdea.com'),
(102, '廣積科技(股)公司', '', '', 'http://www.ibase.com.tw'),
(103, '點子研創有限公司', '', '', 'https://website2122.wixsite.com/ideai'),
(104, '愛易控科技股份有限公司', '', '', 'http://www.iecont.com/'),
(105, '威強工業電腦股份有限公司（萬視旺）', '威強', '', 'http://www.indstech.com'),
(106, '當若科技藝術股份有限公司', '', '', '　'),
(107, '工業技術研究院影像顯示科技中心', '', '', 'http://www.itri.org.tw/chi/dtc/'),
(108, '財團法人資訊工業策進會', '', '', 'http://www.iii.org.tw'),
(109, '美商英特爾亞太科技有限公司台灣分公司', '', '', 'http://www.intel.com.tw'),
(110, '捷格科技股份有限公司', '', '', 'http://jaguartech.com.tw/'),
(111, '金隆系統科技(股)公司', '', '', 'http://www.jinlong.com.tw/'),
(112, '建詳科技股份有限公司', '', '', 'http://www.jxg.tw'),
(113, '京徹股份有限公司', '', '', 'http://www.jing-store.com.tw'),
(114, '佳樂科技有限公司', '', '', 'http://www.joyplux.com.tw'),
(115, '騰騏科技(股)公司', '', '', 'http://www.joyvision-3d.com/'),
(116, '美商CONNECTPRO 台灣分公司/均昂科技股份有限公司', '', '', 'http://www.june-on.com'),
(117, '串串創意(股)公司', '', '', 'www.lookr.io'),
(118, '康順電子科技有限公司', '', '', 'http://www.kstek.com.tw/'),
(119, '高雄晶傑達光電科技股份有限公司', '', '', 'http://www.koe.j-display.com/'),
(120, '凱太數位(股)公司', '', '', 'http://www.katdc.com/'),
(121, '廣樵集團 / 廣科科技有限公司', '', '', 'http://www.kepro.com.tw/ict.html'),
(122, '創藝盒子數位有限公司', '', '', 'www .kinetobox.com'),
(123, '光寶科技', '', '', 'http://www.liteon.com/index.aspx'),
(124, '晶達光電(股)公司', '', '', 'http://www.litemax.com'),
(125, '遠翰科技股份有限公司', '', '', 'http://www.emage.com.tw/'),
(126, '凌暉科技股份有限公司', '', '', 'http://www.lwodisplay.com/ch/index.php'),
(127, '原形研發科股份有限公司', '', '', 'http://www.inXtron.com'),
(128, '做人成功文創股份有限公司', '', '', 'www.ego3d.com.tw'),
(129, '帆宣系統科技(股)公司', '', '', 'http://www.micb2b.com'),
(130, '茂緯股份有限公司', '', '', 'http://www.maxtinc.com'),
(131, '承大科技有限公司', '', '', 'http://www.maxtek-go-go.com'),
(132, '銓鼎科技股份有限公司', '', '', 'http://www.maxwin.com.tw'),
(133, '數位魔方科技股份有限公司', '', '', 'http://www.mediaguide.com.tw'),
(134, '鎂成實業有限公司', '', '', 'http://www.meicheng.com.tw/'),
(135, '微星科技股份有限公司', '微星', '02-80243989', 'http://www.msi.com'),
(136, '微巨行動科技股份有限公司', '', '', 'http://www.pass2u.net'),
(137, '佑叡企業有限公司', '', '', 'http://www.midasolution.com/midashow'),
(138, '青輔實業股份有限公司', '', '', 'http://www.mosolid.com.tw'),
(139, '高瞻資訊股份有限公司', '', '', 'www.moremote.com'),
(140, '鴻友科技(股)有限公司', '', '', 'http://www.mustek.com.tw'),
(141, '科睿系統(股)公司', '', '', 'http://www.mte.com.tw'),
(142, '波國際(股)公司', '', '', 'http://www.nami.com.tw'),
(143, '富網股份有限公司', '', '', 'http://www.netad.tv'),
(144, '瀚錸科技股份有限公司', '', '', 'www.netbridgetech.com.tw'),
(145, '新漢電腦', '', '', 'http://www.nexcom.com.tw'),
(146, '新視代科技股份有限公司', '', '', 'http://www.chimei.com.tw/'),
(147, '諾亞媒體媒體股份有限公司', '', '', 'http://www.novamedia.com.tw'),
(148, '尚福國際科技有限公司', '', '', ''),
(149, '荃能國際有限公司', '', '', 'www.mirconn.com'),
(150, '好棒棒創意股份有限公司', '', '', 'https://www.oisee.cool'),
(151, '光磊科技股份有限公司', '', '', 'http://www.opto.com.tw'),
(152, '辰翰國際有限公司', '', '', 'http://www.orbstar.com.tw/'),
(153, '歐睿電通(股)公司', '', '', ''),
(154, '台灣松下電器股份有限公司', '', '', 'http://www.panasonic.com.tw/Home/'),
(155, '碩穎科技有限公司', '', '', 'http://www.sapphirepgs.com'),
(156, '包安科技股份有限公司', '', '', 'http://www.paoan.com.tw'),
(157, '香港商?景電子有限公司台灣分公司', '', '', 'http://www.pcvision.com.hk'),
(158, '飛宏科技股份有限公司', '', '', 'http://www.nlighten.com'),
(159, '台灣螢端科技股份有限公司', '', '', 'http://www.phistek.com'),
(160, '攝影人數位影像製作股份有限公司', '', '', 'http://www.pmi.com.tw'),
(161, '菩蘭凝數位服務有限公司', '', '', 'http://itplanning.terapad.com'),
(162, '鈦揚晶業股份有限公司', '', '', 'http://www.polysight.com'),
(163, '柚橘創意科技有限公司', '', '', 'www.pomeoran.com'),
(164, '瑞傳科技', '', '', 'http://www.tw.portwell.com.tw/contact/'),
(165, '保修通科技(股)公司', '', '', 'http://www.presto.com.tw'),
(166, '致伸科技股份有限公司', '', '', 'http://www.primax.com.tw'),
(167, '弘勝光電(股)公司', '', '', 'http://www.probright.com.tw'),
(168, '大樣光電科技有限公司', '', '', 'http://www.proled.com.tw'),
(169, '南京資訊(股)', '', '', 'http://www.protech.com.tw/'),
(170, '推手媒體股份有限公司', '', '', 'www.pushhands.media'),
(171, '和暢科技股份有限公司', '', '', 'www.QbicTechnology.com'),
(172, '佳世達科技股份有限公司', '', '', 'http://www.Qisda.com'),
(173, '長傳科技股份有限公司', '', '', 'http://www.qniq.com.tw'),
(174, '光宸科技(股)公司', '', '', 'http://www.quanmax.com'),
(175, '廣達電腦(股)公司', '', '', 'http://www.quantatw.com'),
(176, '瑞迪國際股份有限公司', '', '', 'http://www.radi.com.tw'),
(177, '瑞訊智能(股)公司', '', '', 'www.rapidsignage.com'),
(178, '聲寶(股)公司', '', '', 'http://www.sampo.com.tw'),
(179, '台灣三星電子股份有限公司', '', '', 'www.samsung.com.tw'),
(180, '宏宣科技媒體有限公司', '', '', 'http://website.mediadrive.com.tw/scopetech-about/'),
(181, '碩擎科技股份有限公司', '', '', 'http://www.serafim-tech.com'),
(182, '新誼整合科技股份有限公司', '', '', 'http://www.shinsoft.com.tw'),
(183, '浩鑫股份有限公司', '', '', 'http://www.shuttle.com'),
(184, '金揚資訊科技股份有限公司　', '', '', 'http://www.quickmark.com.tw'),
(185, '琦錸科技股份有限公司', '', '', 'http://www.SIMPLIVE.COM'),
(186, '信業科技股份有限公司', '', '', 'http://www.sinew.com.tw'),
(187, '大中積體電路(股)公司', '', '', ''),
(188, '擎泰科技', '', '', 'http://www.skymedi.com.tw'),
(189, '睿橋科技股份有限公司', '', '', 'http://www.smartbridge-tech.com/'),
(190, '虹晶科技股份有限公司', '', '', 'http://www.socle-tech.com/'),
(191, '捷騰光電股份有限公司', '', '', 'http://www.sbravo.com.tw'),
(192, '創利空間股份有限公司', '', '', 'www.space4money.com'),
(193, '立奕企業股份有限公司', '', '', 'http://www.SPIRITON.COM.TW'),
(194, '尚立股份有限公司', '', '', 'http://www.sunnic.com.tw'),
(195, '昌曜科技股份有限公司', '', '', 'http://www.sunvision.com.tw'),
(196, '軒慶股份有限公司', '', '', 'http://www.sutangtek.com.tw'),
(197, '安齊電子(股)公司', '', '', ''),
(198, '新茂國際科技股份有限公司', '', '', 'http://www.syncmos.com.tw/'),
(199, '禾畚興業有限公司', '', '', 'http://www.ameleks.com'),
(200, '華產科技(股)公司', '', '', '　'),
(201, '兆發科技股份有限公司', '', '', 'www.t-win.com.tw'),
(202, '台灣立體視訊股份有限公司', '', '', 'http://www.taiwan3dtv.com'),
(203, '台灣色彩與影像科技股份有限公司', '', '', 'http://www.tcit.com.tw'),
(204, '炬嘉股份有限公司', '', '', 'www.slim-light.com.tw'),
(205, '天合資訊股份有限公司', '', '', 'http://www.teamup.com.tw'),
(206, '東友科技股份有限公司', '', '', 'http://www.tecoimage.com.tw/'),
(207, '東元奈米應材(股)公司', '', '', 'http://www.teconano.com.tw/'),
(208, '天宇電子有限公司', '', '', 'http://www.tyt.com.tw'),
(209, '翔琥科技工程國際有限公司', '', '', 'http://www.thetigerparty.com/'),
(210, '通泰傳媒科技有限公司', '', '', 'http://www.phimedia.tv'),
(211, '弘和科技股份有限公司', '', '', 'http://www.uglobal.com.tw/'),
(212, '佑霖科技股份有限公司', '', '', 'http://www.uniclass.com.tw'),
(213, '精技電腦股份有限公司', '精技', '02-27962345', 'http://www.unitech-utp.com.tw/'),
(214, '詠朋科技股份有限公司', '', '', ''),
(215, '幸楷科技股份有限公司', '', '', 'http://www.uptmate.com.tw'),
(216, '由田新技(股)公司', '', '', 'http://www.utechzone.com.tw'),
(217, '勝承科技有限公司', '', '', 'http://www.vcheng.com.tw'),
(218, '維嘉全球科技(股)公司', '', '', 'http://www.vega-global.com.tw'),
(219, '威盛電子股份有限公司', '', '', 'http://www.viatech.com'),
(220, '法商媒體之島股份有限公司', '', '', 'www.viadirect.com/en'),
(221, '萬瑞達科技(股)公司', '', '', 'http://www.viwynn.com.tw'),
(222, '呈現股份有限公司', '', '', 'http://www.vitaltouch.com.tw'),
(223, '承遠科技股份有限公司', '', '', ''),
(224, '萬博實業股份有限公司', '', '', 'http://www.wbcall.com'),
(225, '展碁國際股份有限公司', '', '', 'www.weblink.com.tw'),
(226, '崴聯科技', '', '', 'http://www.we-link.com.tw/'),
(227, '韋福電子有限公司', '', '', 'http://www.WELLFROCE.COM.TW'),
(228, '中美萬泰科技股份有限公司', '', '', 'http://www.wincomm.com.tw'),
(229, '融程電訊股份有限公司', '', '', 'http://www.winmate.com.tw'),
(230, '勝華科技股份有限公司', '', '', 'http://www.wintek.com.tw'),
(231, '緯創資通股份有限公司', '', '', 'http://www.wistron.com.tw/index.htm'),
(232, '蟲蟲多媒體', '', '', ''),
(233, '相信典子有限公司', '', '', 'www.xbeacon.info'),
(234, '翔基國際有限公司', '', '', 'http://www.xi-ji.com'),
(235, '友尚股份有限公司', '', '', 'http://www.yosungroup.com'),
(236, '揚昇照明股份有限公司', '', '', 'http://www.younglighting.com'),
(237, '揚明光學股份有限公司', '', '', 'http://www.youngoptics.com/chinese/'),
(238, '英商勝創利有限公司', '', '', 'www.zytronic.co.uk'),
(239, '瑞祥整合行銷(有)公司', '', '', ''),
(240, '良映資訊(股)公司', '', '', ''),
(241, '瑞立國際(股)公司', '', '', ''),
(242, '新碩科技有限公司', '', '', 'http://www.hualien.com.tw'),
(243, '弘典科技有限公司', '', '', 'http://www.8317.com.tw'),
(244, 'EVGA艾維克科技股份有限公司', 'EVGA', '0800-282868', 'https://tw.evga.com/'),
(255, '聯強國際股份有限公司', '聯強', '02-25063320', 'http://www.synnex.com.tw/'),
(256, 'Montech君主科技', 'Montech', '03-3274054', 'https://www.telon.com.tw/tc/'),
(257, '富基電通股份有限公司', '富基電通', '02-89786066', 'https://www.afastor.com.tw/'),
(258, '建達國際股份有限公司', '建達', '02-26028111', 'http://www.xander.com.tw/user2/home/'),
(259, '捷元股份有限公司', '捷元', '02-27956677', 'https://www.genuine.com.tw/'),
(260, '日森興業有限公司', '日森興業', '02-86626221', 'http://www.nisam.com.tw/about_us.htm'),
(261, '振華電腦有限公司', '振華', '02-29085366', 'https://www.super-flower.com.tw/'),
(262, '海韻電子工業股份有限公司', '海韻', '03-2719768', 'https://seasonic.com'),
(263, '華碩電腦股份有限公司', '華碩', '02-28943447', 'https://www.asus.com/tw/'),
(264, '佳多力有限公司', '佳多力', '02-27593917', 'https://www.mrpower.com.tw/'),
(265, '騰網科技股份有限公司', '騰網科技', '02-25815729', 'https://www.coolermaster.com/tw/zh-tw/');

-- --------------------------------------------------------

--
-- 資料表結構 `cooler`
--

CREATE TABLE `cooler` (
  `Co_model` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `socket` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `cooler`
--

INSERT INTO `cooler` (`Co_model`, `socket`, `brand`, `price`) VALUES
(' HR-02 Plus V', '2066', '利民', 2400),
(' HR-02 Plus W4', '1200_400', '利民', 2400),
(' HR-02 Plus W5', '1200_500', '利民', 2400),
(' HR-02 Plus X', 'AM4', '利民', 2400),
(' NH-D15S chromax.black 黑化版 V', '2066', '貓頭鷹', 3665),
(' NH-D15S chromax.black 黑化版 W4', '1200_400', '貓頭鷹', 3665),
(' NH-D15S chromax.black 黑化版 W5', '1200_500', '貓頭鷹', 3665),
(' NH-D15S chromax.black 黑化版 X', 'AM4', '貓頭鷹', 3665),
(' Venomous Plus V', '2066', '利民', 2200),
(' Venomous Plus W4', '1200_400', '利民', 2200),
(' Venomous Plus W5', '1200_500', '利民', 2200),
(' Venomous Plus X', 'AM4', '利民', 2200),
('Archon IB-E X2 散熱器 V', '2066', '利民', 2390),
('Archon IB-E X2 散熱器 W4', '1200_400', '利民', 2390),
('Archon IB-E X2 散熱器 W5', '1200_500', '利民', 2390),
('Archon IB-E X2 散熱器 X', 'AM4', '利民', 2390),
('ARO-M14O Ryzen X', 'AM4', '利民', 1600),
('Assassin King 刺靈王 120 Plus V', '2066', '利民', 1150),
('Assassin King 刺靈王 120 Plus W4', '1200_400', '利民', 1150),
('Assassin King 刺靈王 120 Plus W5', '1200_500', '利民', 1150),
('Assassin King 刺靈王 120 Plus X', 'AM4', '利民', 1150),
('Assassin King 刺靈王 120 黑化版 V', '2066', '利民', 1350),
('Assassin King 刺靈王 120 黑化版 W4', '1200_400', '利民', 1350),
('Assassin King 刺靈王 120 黑化版 W5', '1200_500', '利民', 1350),
('Assassin King 刺靈王 120 黑化版 X', 'AM4', '利民', 1350),
('Assassin Spirit 刺靈 120 Plus V', '2066', '利民', 890),
('Assassin Spirit 刺靈 120 Plus W4', '1200_400', '利民', 890),
('Assassin Spirit 刺靈 120 Plus W5', '1200_500', '利民', 890),
('Assassin Spirit 刺靈 120 Plus X', 'AM4', '利民', 890),
('Frost Spirit 霜靈 140 V', '2066', '利民', 1500),
('Frost Spirit 霜靈 140 W4', '1200_400', '利民', 1500),
('Frost Spirit 霜靈 140 W5', '1200_500', '利民', 1500),
('Frost Spirit 霜靈 140 X', 'AM4', '利民', 1500),
('Hyper 212 Black Edition V', '2066', '酷碼', 1090),
('Hyper 212 Black Edition W4', '1200_400', '酷碼', 1090),
('Hyper 212 Black Edition W5', '1200_500', '酷碼', 1090),
('Hyper 212 Black Edition X', 'AM4', '酷碼', 1090),
('Hyper 212 EVO V2 散熱器 V', '2066', '酷碼', 990),
('Hyper 212 EVO V2 散熱器 W4', '1200_400', '酷碼', 990),
('Hyper 212 EVO V2 散熱器 W5', '1200_500', '酷碼', 990),
('Hyper 212 EVO V2 散熱器 X', 'AM4', '酷碼', 990),
('Hyper 212 LED Turbo ARGB V', '2066', '酷碼', 1390),
('Hyper 212 LED Turbo ARGB W4', '1200_400', '酷碼', 1390),
('Hyper 212 LED Turbo ARGB W5', '1200_500', '酷碼', 1390),
('Hyper 212 LED Turbo ARGB X', 'AM4', '酷碼', 1390),
('Hyper 212 LED Turbo V', '2066', '酷碼', 1090),
('Hyper 212 LED Turbo W4', '1200_400', '酷碼', 1090),
('Hyper 212 LED Turbo W5', '1200_500', '酷碼', 1090),
('Hyper 212 LED Turbo X', 'AM4', '酷碼', 1090),
('Hyper D92 雙扇 V', '2066', '酷碼', 1230),
('Hyper D92 雙扇 W4', '1200_400', '酷碼', 1230),
('Hyper D92 雙扇 W5', '1200_500', '酷碼', 1230),
('Hyper D92 雙扇 X', 'AM4', '酷碼', 1230),
('Hyper H410R 散熱器 V', '2066', '酷碼', 790),
('Hyper H410R 散熱器 W4', '1200_400', '酷碼', 790),
('Hyper H410R 散熱器 W5', '1200_500', '酷碼', 790),
('Hyper H410R 散熱器 X', 'AM4', '酷碼', 790),
('Hyper T20 散熱器 W4', '1200_400', '酷碼', 499),
('Hyper T20 散熱器 W5', '1200_500', '酷碼', 499),
('Hyper T20 散熱器 X', 'AM4', '酷碼', 499),
('Hyper T200 W4', '1200_400', '酷碼', 590),
('Hyper T200 W5', '1200_500', '酷碼', 590),
('Hyper T200 X', 'AM4', '酷碼', 590),
('Hyper TX3 EVO W4', '1200_400', '酷碼', 699),
('Hyper TX3 EVO W5', '1200_500', '酷碼', 699),
('Hyper TX3 EVO X', 'AM4', '酷碼', 699),
('Le Grand Macho RT 散熱器 V', '2066', '利民', 2290),
('Le Grand Macho RT 散熱器 W4', '1200_400', '利民', 2290),
('Le Grand Macho RT 散熱器 W5', '1200_500', '利民', 2290),
('Le Grand Macho RT 散熱器 X', 'AM4', '利民', 2290),
('Macho 120 SBM V', '2066', '利民', 1290),
('Macho 120 SBM W4', '1200_400', '利民', 1290),
('Macho 120 SBM W5', '1200_500', '利民', 1290),
('Macho 120 SBM X', 'AM4', '利民', 1290),
('MasterAir MA410P RGB V', '2066', '酷碼', 1090),
('MasterAir MA410P RGB W4', '1200_400', '酷碼', 1090),
('MasterAir MA410P RGB W5', '1200_500', '酷碼', 1090),
('MasterAir MA410P RGB X', 'AM4', '酷碼', 1090),
('MasterAir MA612 Stealth ARGB 黑化版 V', '2066', '酷碼', 2590),
('MasterAir MA612 Stealth ARGB 黑化版 W4', '1200_400', '酷碼', 2590),
('MasterAir MA612 Stealth ARGB 黑化版 W5', '1200_500', '酷碼', 2590),
('MasterAir MA612 Stealth ARGB 黑化版 X', 'AM4', '酷碼', 2590),
('MasterAir MA612 Stealth 黑化版 V', '2066', '酷碼', 2290),
('MasterAir MA612 Stealth 黑化版 W4', '1200_400', '酷碼', 2290),
('MasterAir MA612 Stealth 黑化版 W5', '1200_500', '酷碼', 2290),
('MasterAir MA612 Stealth 黑化版 X', 'AM4', '酷碼', 2290),
('MasterAir MA620M 雙塔散熱器 V', '2066', '酷碼', 2890),
('MasterAir MA620M 雙塔散熱器 W4', '1200_400', '酷碼', 2890),
('MasterAir MA620M 雙塔散熱器 W5', '1200_500', '酷碼', 2890),
('MasterAir MA620M 雙塔散熱器 X', 'AM4', '酷碼', 2890),
('NH-D15 chromax.black 黑化版 V', '2066', '貓頭鷹', 3895),
('NH-D15 chromax.black 黑化版 W4', '1200_400', '貓頭鷹', 3895),
('NH-D15 chromax.black 黑化版 W5', '1200_500', '貓頭鷹', 3895),
('NH-D15 chromax.black 黑化版 X', 'AM4', '貓頭鷹', 3895),
('NH-D15 V', '2066', '貓頭鷹', 3615),
('NH-D15 W4', '1200_400', '貓頭鷹', 3615),
('NH-D15 W5', '1200_500', '貓頭鷹', 3615),
('NH-D15 X', 'AM4', '貓頭鷹', 3615),
('NH-D15S V', '2066', '貓頭鷹', 3275),
('NH-D15S W4', '1200_400', '貓頭鷹', 3275),
('NH-D15S W5', '1200_500', '貓頭鷹', 3275),
('NH-D15S X', 'AM4', '貓頭鷹', 3275),
('NH-D9L V', '2066', '貓頭鷹', 2125),
('NH-D9L W4', '1200_400', '貓頭鷹', 2125),
('NH-D9L W5', '1200_500', '貓頭鷹', 2125),
('NH-D9L X', 'AM4', '貓頭鷹', 2125),
('NH-U12A V', '2066', '貓頭鷹', 3885),
('NH-U12A W4', '1200_400', '貓頭鷹', 3885),
('NH-U12A W5', '1200_500', '貓頭鷹', 3885),
('NH-U12A X', 'AM4', '貓頭鷹', 3885),
('NH-U12S chromax.black 黑化版 V', '2066', '貓頭鷹', 2585),
('NH-U12S chromax.black 黑化版 W4', '1200_400', '貓頭鷹', 2585),
('NH-U12S chromax.black 黑化版 W5', '1200_500', '貓頭鷹', 2585),
('NH-U12S chromax.black 黑化版 X', 'AM4', '貓頭鷹', 2585),
('NH-U12S TR4-SP3 Y4', 'TRX40', '貓頭鷹', 2660),
('NH-U12S TR4-SP3 Y8', 'WRX80', '貓頭鷹', 2660),
('NH-U12S V', '2066', '貓頭鷹', 2420),
('NH-U12S W4', '1200_400', '貓頭鷹', 2420),
('NH-U12S W5', '1200_500', '貓頭鷹', 2420),
('NH-U12S X', 'AM4', '貓頭鷹', 2420),
('NH-U14S TR4-SP3 Y4', 'TRX40', '貓頭鷹', 3085),
('NH-U14S TR4-SP3 Y8', 'WRX80', '貓頭鷹', 3085),
('NH-U14S V', '2066', '貓頭鷹', 2650),
('NH-U14S W4', '1200_400', '貓頭鷹', 2650),
('NH-U14S W5', '1200_500', '貓頭鷹', 2650),
('NH-U14S X', 'AM4', '貓頭鷹', 2650),
('NH-U9 TR4-SP3 Y4', 'TRX40', '貓頭鷹', 2670),
('NH-U9 TR4-SP3 Y8', 'WRX80', '貓頭鷹', 2670),
('NH-U9S V', '2066', '貓頭鷹', 2345),
('NH-U9S W4', '1200_400', '貓頭鷹', 2345),
('NH-U9S W5', '1200_500', '貓頭鷹', 2345),
('NH-U9S X', 'AM4', '貓頭鷹', 2345),
('Silver Arrow 130 V', '2066', '利民', 2150),
('Silver Arrow 130 W4', '1200_400', '利民', 2150),
('Silver Arrow 130 W5', '1200_500', '利民', 2150),
('Silver Arrow 130 X', 'AM4', '利民', 2150),
('Silver Arrow IB-E Extreme Rev.B V', '2066', '利民', 2890),
('Silver Arrow IB-E Extreme Rev.B W4', '1200_400', '利民', 2890),
('Silver Arrow IB-E Extreme Rev.B W5', '1200_500', '利民', 2890),
('Silver Arrow IB-E Extreme Rev.B X', 'AM4', '利民', 2890),
('Silver Arrow T8 V', '2066', '利民', 2400),
('Silver Arrow T8 W4', '1200_400', '利民', 2400),
('Silver Arrow T8 W5', '1200_500', '利民', 2400),
('Silver Arrow T8 X', 'AM4', '利民', 2400),
('Silver Arrow TR4 Y4', 'TRX40', '利民', 2990),
('Silver Arrow TR4 Y8', 'WRX80', '利民', 2990),
('True Spirit 120(Rev.B) Plus V', '2066', '利民', 1390),
('True Spirit 120(Rev.B) Plus W4', '1200_400', '利民', 1390),
('True Spirit 120(Rev.B) Plus W5', '1200_500', '利民', 1390),
('True Spirit 120(Rev.B) Plus X', 'AM4', '利民', 1390),
('True Spirit 120M(Rev.B) 灰色風罩 V', '2066', '利民', 990),
('True Spirit 120M(Rev.B) 灰色風罩 W4', '1200_400', '利民', 990),
('True Spirit 120M(Rev.B) 灰色風罩 W5', '1200_500', '利民', 990),
('True Spirit 120M(Rev.B) 灰色風罩 X', 'AM4', '利民', 990),
('True Spirit 140 Direct V', '2066', '利民', 1290),
('True Spirit 140 Direct W4', '1200_400', '利民', 1290),
('True Spirit 140 Direct W5', '1200_500', '利民', 1290),
('True Spirit 140 Direct X', 'AM4', '利民', 1290),
('True Spirit 90M(Rev.B) W4', '1200_400', '利民', 840),
('True Spirit 90M(Rev.B) W5', '1200_500', '利民', 840),
('True Spirit 90M(Rev.B) X', 'AM4', '利民', 840),
('酷碼 Hyper 212 V2 散熱器 V', '2066', '酷碼', 790),
('酷碼 Hyper 212 V2 散熱器 W4', '1200_400', '酷碼', 790),
('酷碼 Hyper 212 V2 散熱器 W5', '1200_500', '酷碼', 790),
('酷碼 Hyper 212 V2 散熱器 X', 'AM4', '酷碼', 790);

-- --------------------------------------------------------

--
-- 資料表結構 `cooler_brand`
--

CREATE TABLE `cooler_brand` (
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `cooler_brand`
--

INSERT INTO `cooler_brand` (`brand`) VALUES
('利民'),
('貓頭鷹'),
('酷碼');

-- --------------------------------------------------------

--
-- 資料表結構 `cpu`
--

CREATE TABLE `cpu` (
  `CPU_model` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `CPU_TDP` int(10) NOT NULL,
  `propose` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `socket` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `clock` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `cpu`
--

INSERT INTO `cpu` (`CPU_model`, `CPU_TDP`, `propose`, `socket`, `clock`, `brand`, `price`) VALUES
('i3-10100', 65, '文書', '1200_400', '3.6G(↑4.3G)Hz', 'Intel', 3990),
('i3-10100F', 65, '文書', '1200_400', '3.6G(↑4.3G)Hz', 'Intel', 2500),
('i5-10400', 65, '遊戲', '1200_400', '2.9G(↑4.3G)Hz', 'Intel', 5100),
('i5-10400F', 65, '遊戲', '1200_400', '2.9G(↑4.3G)Hz', 'Intel', 4400),
('i5-10500', 65, '遊戲', '1200_400', '3.1G(↑4.5G)Hz', 'Intel', 5900),
('i5-10600K', 95, '遊戲', '1200_400', '4.1G(↑4.8G)Hz', 'Intel', 8400),
('i5-10600KF', 95, '遊戲', '1200_400', '4.1G(↑4.8G)Hz', 'Intel', 7980),
('i5-11400', 65, '遊戲', '1200_500', '2.6G(↑4.4G)Hz', 'Intel', 5600),
('i5-11500', 65, '遊戲', '1200_500', '2.7G(↑4.6G)Hz', 'Intel', 6700),
('i7-10700', 65, '遊戲', '1200_400', '2.9G(↑4.8G)Hz', 'Intel', 8880),
('i7-10700F', 65, '遊戲', '1200_400', '2.9G(↑4.8G)Hz', 'Intel', 8100),
('i7-10700K', 125, '遊戲', '1200_400', '3.8G(↑5.1G)Hz', 'Intel', 10300),
('i7-10700KF', 125, '遊戲', '1200_400', '3.8G(↑5.1G)Hz', 'Intel', 9999),
('i7-11700K', 125, '遊戲', '1200_500', '3.6G(↑5.0G)Hz', 'Intel', 12200),
('i7-11700KF', 125, '遊戲', '1200_500', '3.6G(↑5.0G)Hz', 'Intel', 11500),
('i9-10900', 65, '遊戲', '1200_400', '2.5G(↑5.2G)Hz', 'Intel', 12400),
('i9-10900F', 65, '遊戲', '1200_400', '2.8G(↑5.2G)Hz', 'Intel', 11500),
('i9-10900K', 125, '遊戲', '1200_400', '3.7G(↑5.3G)Hz', 'Intel', 14900),
('i9-10900KF', 125, '遊戲', '1200_400', '3.7G(↑5.3G)Hz', 'Intel', 14300),
('i9-10900X', 165, '伺服器', '2066', '3.7G(↑4.5G)Hz', 'Intel', 18200),
('i9-10940X', 165, '伺服器', '2066', '3.3G(↑4.6G)Hz', 'Intel', 24200),
('i9-10980XE', 165, '伺服器', '2066', '3.0G(↑4.6G)Hz', 'Intel', 30500),
('i9-11900', 65, '遊戲', '1200_500', '2.5G(↑5.2G)Hz', 'Intel', 13700),
('i9-11900F', 65, '遊戲', '1200_500', '2.5G(↑5.2G)Hz', 'Intel', 13200),
('i9-11900K', 125, '遊戲', '1200_500', '3.5G(↑5.3G)Hz', 'Intel', 17500),
('i9-11900KF', 125, '遊戲', '1200_500', '3.5G(↑5.3G)Hz', 'Intel', 16900),
('Pentium Gold G6400', 58, '文書', '1200_400', '4GHz', 'Intel', 1999),
('R3 3100', 65, '文書', 'AM4', '3.6G(↑3.9G)Hz', 'AMD', 3250),
('R3 3300X', 65, '文書', 'AM4', '3.8G(↑4.3G)Hz', 'AMD', 3799),
('R5 3600', 65, '遊戲', 'AM4', '3.6G(↑4.2G)Hz', 'AMD ', 5650),
('R5 5600X', 65, '遊戲', 'AM4', '3.7G(↑4.6G)Hz', 'AMD', 8970),
('R7 3700X', 65, '遊戲', 'AM4', '3.6G(↑4.4G)Hz', 'AMD', 9250),
('R7 3800X', 105, '遊戲', 'AM4', '3.9G(↑4.5G)Hz', 'AMD ', 12770),
('R7 5800X', 105, '遊戲', 'AM4', '3.8G(↑4.7G)Hz', 'AMD', 13470),
('R9 3900X', 105, '遊戲', 'AM4', '3.8G(↑4.6G)Hz', 'AMD', 14599),
('R9 3950X', 105, '遊戲', 'AM4', '3.5G(↑4.7G)Hz', 'AMD', 23470),
('R9 5900X', 105, '遊戲', 'AM4', '3.7G(↑4.8G)Hz', 'AMD', 16470),
('TR 3990X', 280, '伺服器', 'TRX40', '2.9G(↑4.3G)Hz', 'AMD', 123000),
('TR PRO 3955WX', 280, '伺服器', 'WRX80', '3.9G(↑4.3G)Hz', 'AMD', 34970),
('TR PRO 3975WX', 280, '伺服器', 'WRX80', '3.5G(↑4.2G)Hz', 'AMD', 82470),
('TR PRO 3995WX', 280, '伺服器', 'WRX80', '2.7G(↑4.2G)Hz', 'AMD', 169770);

-- --------------------------------------------------------

--
-- 資料表結構 `cpu_brand`
--

CREATE TABLE `cpu_brand` (
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `cpu_brand`
--

INSERT INTO `cpu_brand` (`brand`) VALUES
('AMD'),
('Intel');

-- --------------------------------------------------------

--
-- 資料表結構 `CPU_TDP`
--

CREATE TABLE `CPU_TDP` (
  `CPU_TDP` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `CPU_TDP`
--

INSERT INTO `CPU_TDP` (`CPU_TDP`) VALUES
(58),
(65),
(95),
(105),
(125),
(165),
(280);

-- --------------------------------------------------------

--
-- 資料表結構 `c_case`
--

CREATE TABLE `c_case` (
  `Ca_model` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `size` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `length` float NOT NULL,
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `c_case`
--

INSERT INTO `c_case` (`Ca_model`, `size`, `length`, `brand`, `price`) VALUES
('Montech Air 100 ARGB', 'M-ATX', 33, 'Montech', 1690),
('Montech Air 900', 'E-ATX', 37, 'Montech', 1390),
('Montech Air 900 ARGB', 'E-ATX', 37, 'Montech', 1790),
('Montech Air 900 Mesh', 'E-ATX', 37, 'Montech', 1690),
('Montech Air X ', 'ATX', 34, 'Montech', 1890),
('Montech SKY ONE', 'E-ATX', 40, 'Montech', 2290),
('Montech X1 ', 'ATX', 30.5, 'Montech', 1090),
('Montech X3 MESH ', 'ATX', 30.5, 'Montech', 1490),
('Montech 守護神', 'ATX', 40, 'Montech', 1390),
('Montech 拳擊手 Fighter 400', 'ATX', 33, 'Montech', 990),
('Montech 拳擊手 Fighter 500 ', 'ATX', 32, 'Montech', 1190),
('Montech 破壞俠', 'ATX', 36, 'Montech', 990),
('Montech 雙子座', 'ATX', 30, 'Montech', 1290),
('Montech 飛行者 ', 'M-ATX', 30, 'Montech', 1190),
('NZXT H510 ', 'ATX', 38.1, 'NZXT', 2990),
('NZXT H510 Elite ', 'ATX', 36.8, 'NZXT', 5690),
('NZXT H510i ', 'ATX', 38.1, 'NZXT', 3990),
('NZXT H710 ', 'E-ATX', 41.3, 'NZXT', 5290),
('NZXT H710i', 'E-ATX', 41.3, 'NZXT', 6690),
('全漢 CMT211B', 'ATX', 32, '全漢', 1090),
('全漢 CMT211W', 'ATX', 32, '全漢', 1190),
('全漢 CMT220 聖俠士', 'ATX', 40, '全漢', 1090),
('全漢 CMT240B 炫鬥士', 'ATX', 37.3, '全漢', 1090),
('全漢 CMT240W 炫鬥士', 'ATX', 37.3, '全漢', 1190),
('全漢 CMT271 闇星爵', 'ATX', 32.5, '全漢', 990),
('全漢 CMT281', 'ATX', 31.5, '全漢', 1390),
('全漢 CMT282', 'ATX', 31.5, '全漢', 1290),
('全漢 CMT311 炫風俠', 'ATX', 32, '全漢', 1790),
('全漢 CMT321 炫俠客', 'ATX', 35.5, '全漢', 1990),
('全漢 CMT360 ', 'E-ATX', 38, '全漢', 1990),
('全漢 CMT520 光戰警 Plus', 'E-ATX', 42.3, '全漢', 2390),
('全漢 CMT540', 'E-ATX', 38, '全漢', 1990),
('全漢 CST310 小坦克', 'M-ATX', 37.5, '全漢', 1490),
('全漢 CST320 靜化論', 'M-ATX', 39.3, '全漢', 1590),
('全漢 CST340 小神盾', 'M-ATX', 37.5, '全漢', 1790),
('全漢 CST350', 'M-ATX', 24.5, '全漢', 1890);

-- --------------------------------------------------------

--
-- 資料表結構 `gpu`
--

CREATE TABLE `gpu` (
  `G_model` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `G_TDP` int(10) NOT NULL,
  `propose` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `length` float NOT NULL,
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `gpu`
--

INSERT INTO `gpu` (`G_model`, `G_TDP`, `propose`, `length`, `brand`, `price`) VALUES
('AORUS 3060 ELITE 12G', 170, '遊戲', 29.6, '技嘉', 15990),
('AORUS RTX3060TI ELITE 8G', 200, '遊戲', 29.6, '技嘉', 20490),
('AORUS RTX3060Ti MASTER 8G', 200, '遊戲', 29, '技嘉', 21090),
('AORUS RTX3070 MASTER 8G', 220, '遊戲', 29, '技嘉', 25490),
('AORUS RTX3080 MASTER 10G', 320, '遊戲', 31.9, '技嘉', 36090),
('AORUS RTX3090 MASTER 24G', 350, '遊戲', 31.9, '技嘉', 61990),
('AORUS RTX3090 XTREME 24G', 350, '遊戲', 31.9, '技嘉', 63990),
('AORUS RX6800 MASTER 16G', 250, '遊戲', 30, '技嘉', 29790),
('DUAL-GTX1650-O4G', 75, '遊戲', 20.4, '華碩', 5390),
('DUAL-GTX1660S-O6G-EVO', 120, '遊戲', 24.2, '華碩', 11590),
('DUAL-RTX3060-12G', 170, '遊戲', 20, '華碩', 13490),
('DUAL-RTX3060Ti-8G', 200, '遊戲', 26.9, '華碩', 16790),
('DUAL-RTX3060Ti-O8G-MINI', 200, '遊戲', 26.9, '華碩', 15990),
('DUAL-RTX3070-8G', 220, '遊戲', 26.7, '華碩', 19490),
('DUAL-RX6700XT-12G', 230, '遊戲', 29.5, '華碩', 23990),
('GT1030 2GD4 LP OC', 30, '文書', 15, '微星', 2990),
('GT1030 AERO ITX 2GD4 OCV1', 30, '文書', 14.7, '微星', 3290),
('GT1030 OC 2G', 30, '文書', 16.7, '技嘉', 3090),
('GT710 1GD3H LP', 19, '文書', 14.6, '微星', 1590),
('GT710 2GD3 LP', 19, '文書', 14.6, '微星', 1790),
('GT710-4H-SL-2GD5', 19, '文書', 16.7, '華碩', 2290),
('GT710-SL-2GD5', 19, '文書', 16.7, '華碩', 1990),
('GTX1050Ti AERO 4G OCV1', 75, '遊戲', 17, '微星', 4990),
('GTX1650 D6 GAMING X', 75, '遊戲', 24.5, '微星', 6590),
('GTX1650 D6 OC 4G', 75, '遊戲', 15.2, '技嘉', 6090),
('GTX1650 D6 VENTUS XS OCV2', 75, '遊戲', 17.8, '微星', 6190),
('GTX1650 D6 WINDFORCE OC 4G', 75, '遊戲', 19.1, '技嘉', 6290),
('GTX1650 GAMING X 4G', 75, '遊戲', 25.9, '微星', 5990),
('GTX1650 KO ULTRA GAMING 4G D6', 75, '遊戲', 20.2, 'EVGA', 3990),
('GTX1650 SUPER D6 4G', 100, '遊戲', 17.2, '技嘉', 6390),
('GTX1650 SUPER GAMING X 4G', 100, '遊戲', 24.8, '微星', 7290),
('GTX1650 SUPER SC ULTRA GAMING 4G', 100, '遊戲', 20.2, 'EVGA', 5890),
('GTX1650 SUPER WINDFORCE OC 4G', 100, '遊戲', 20.5, '技嘉', 6990),
('GTX1660 OC 6G', 120, '遊戲', 22.4, '技嘉', 10290),
('GTX1660 SUPER OC 6G', 120, '遊戲', 22.4, '技嘉', 11590),
('GTX1660 SUPER VENTUS XS OC', 120, '遊戲', 20.4, '微星', 11500),
('N710D3-2GL', 19, '文書', 14.4, '技嘉', 1790),
('N710D5-1GL', 19, '文書', 15.1, '技嘉', 1590),
('N730-2GD3V3', 65, '文書', 14.5, '微星', 2590),
('N730D5-2GI', 65, '文書', 23, '技嘉', 2590),
('PH-GT1030-O2G', 30, '文書', 18.4, '華碩', 3290),
('PH-GTX1050TI-4G鳳凰版', 75, '遊戲', 19.2, '華碩', 4990),
('PH-GTX1650-O4GD6', 75, '遊戲', 17.4, '華碩', 5990),
('PH-GTX1650-O4GD6-P', 75, '遊戲', 17.8, '華碩', 5990),
('PH-GTX1650S-O4G', 100, '遊戲', 17.4, '華碩', 6390),
('PH-GTX1660-O6G', 120, '遊戲', 17.4, '華碩', 8990),
('PH-GTX1660S-O6G', 120, '遊戲', 17.4, '華碩', 10490),
('PH-RTX3060-12G', 170, '遊戲', 17.7, '華碩', 13390),
('ROG-STRIX-GTX1650-A4GD6-GAMING', 75, '遊戲', 24.1, '華碩', 5590),
('ROG-STRIX-GTX1650-O4GD6-GAMING', 75, '遊戲', 24.1, '華碩', 6690),
('ROG-STRIX-GTX1650S-O4G-GAMING', 100, '遊戲', 24.3, '華碩', 7290),
('ROG-STRIX-RTX2060-6G-EVO-V2-GAMING', 160, '遊戲', 30, '華碩', 14790),
('ROG-STRIX-RTX2060-O6G-EVO-V2-GAMING', 160, '遊戲', 30, '華碩', 14990),
('ROG-STRIX-RTX3060-12G-GAMING', 170, '遊戲', 30, '華碩', 15690),
('ROG-STRIX-RTX3060Ti-O8G-GAMING', 200, '遊戲', 31.9, '華碩', 20990),
('ROG-STRIX-RTX3070-O8G-GAMING', 220, '遊戲', 31.8, '華碩', 24490),
('ROG-STRIX-RTX3080-10G-GAMING', 320, '遊戲', 31.9, '華碩', 31990),
('ROG-STRIX-RTX3090-24G-GAMING', 350, '遊戲', 31.9, '華碩', 54990),
('ROG-STRIX-RX6700XT-O12G-GAMING', 230, '遊戲', 32.2, '華碩', 25990),
('ROG-STRIX-RX6800-O16G-GAMING', 250, '遊戲', 32, '華碩', 30990),
('RTX2060 D6 6G', 160, '遊戲', 22.6, '技嘉', 12890),
('RTX2060 OC 6G', 23, '遊戲', 22.6, '技嘉', 12990),
('RTX2060 VENTUS GP OC', 160, '遊戲', 22.6, '微星', 12900),
('RTX2060 WINDFORCE OC 6G', 160, '遊戲', 26.5, '技嘉', 13390),
('RTX3060 EAGLE OC 12G', 170, '遊戲', 24.2, '技嘉', 13990),
('RTX3060 GAMING OC 12G', 170, '遊戲', 28.2, '技嘉', 15090),
('RTX3060 GAMING X 12G', 170, '遊戲', 27.6, '微星', 14900),
('RTX3060 GAMING X TRIO 12G', 170, '遊戲', 32.3, '微星', 15500),
('RTX3060 VENTUS 2X 12G OC', 170, '遊戲', 23.5, '微星', 13900),
('RTX3060 VENTUS 3X 12G OC', 170, '遊戲', 31.6, '微星', 14500),
('RTX3060 VISION OC 12G', 170, '遊戲', 28, '技嘉', 15590),
('RTX3060 XC GAMING', 170, '遊戲', 21, 'EVGA', 11900),
('RTX3060Ti EAGLE 8G', 200, '遊戲', 24.2, '技嘉', 16790),
('RTX3060Ti FTW3 ULTRA', 200, '遊戲', 28.6, 'EVGA', 14990),
('RTX3060Ti GAMING OC 8G', 200, '遊戲', 28.2, '技嘉', 17590),
('RTX3060Ti GAMING X TRIO', 200, '遊戲', 32.3, '微星', 17900),
('RTX3060Ti VENTUS 2X OC', 200, '遊戲', 23.2, '微星', 15900),
('RTX3060Ti VENTUS 3X OC', 200, '遊戲', 31.6, '微星', 16900),
('RTX3060Ti VISION OC 8G', 200, '遊戲', 28.1, '技嘉', 18090),
('RTX3060Ti XC', 200, '遊戲', 20.2, 'EVGA', 12990),
('RTX3070 EAGLE 8G', 220, '遊戲', 28.2, '技嘉', 20490),
('RTX3070 FTW3 GAMING', 220, '遊戲', 30, 'EVGA', 19990),
('RTX3070 GAMING OC 8G', 220, '遊戲', 28.6, '技嘉', 23490),
('RTX3070 GAMING X TRIO', 220, '遊戲', 32.3, '微星', 21900),
('RTX3070 GAMING Z TRIO', 220, '遊戲', 32.3, '微星', 21900),
('RTX3070 SUPRIM X 8G', 220, '遊戲', 33.5, '微星', 24900),
('RTX3070 VENTUS 2X', 220, '遊戲', 23.2, '微星', 19900),
('RTX3070 VENTUS 2X OC', 220, '遊戲', 23.2, '微星', 19900),
('RTX3070 VENTUS 3X', 220, '遊戲', 30.5, '微星', 20900),
('RTX3070 VENTUS 3X OC', 220, '遊戲', 30.5, '微星', 20900),
('RTX3070 XC3 BLACK GAMING', 220, '遊戲', 28.6, 'EVGA', 16990),
('RTX3070 XC3 GAMING', 220, '遊戲', 28.6, 'EVGA', 18390),
('RTX3080 EAGLE 10G', 320, '遊戲', 32, '技嘉', 28290),
('RTX3080 FTW3 GAMING 10G', 320, '遊戲', 30, 'EVGA', 26390),
('RTX3080 GAMING OC 10G', 320, '遊戲', 32, '技嘉', 32090),
('RTX3080 GAMING TRIO 10G', 320, '遊戲', 32.3, '微星', 28400),
('RTX3080 GAMING X TRIO 10G', 320, '遊戲', 32.3, '微星', 30900),
('RTX3080 SUPRIM X 10G', 320, '遊戲', 33.6, '微星', 34900),
('RTX3080 TURBO 10G', 320, '遊戲', 26.7, '技嘉', 34690),
('RTX3080 VENTUS 3X 10G OC', 320, '遊戲', 30.5, '微星', 29900),
('RTX3080 XC3 Black', 320, '遊戲', 29.8, 'EVGA', 22990),
('RTX3080 XC3 GAMING 10G', 320, '遊戲', 28.5, 'EVGA', 25190),
('RTX3080 XC3 Ultra', 320, '遊戲', 28.5, 'EVGA', 25790),
('RTX3090 24G XC3 ULTRA', 350, '遊戲', 28.5, 'EVGA', 50990),
('RTX3090 EAGLE 24G', 350, '遊戲', 32, '技嘉', 52990),
('RTX3090 FTW3 ULTRA', 350, '遊戲', 30, 'EVGA', 56490),
('RTX3090 GAMING OC 24G', 350, '遊戲', 32, '技嘉', 57990),
('RTX3090 GAMING X TRIO 24G', 350, '遊戲', 33.5, '微星', 56900),
('RTX3090 SUPRIM 24G', 350, '遊戲', 33.6, '微星', 58900),
('RTX3090 VENTUS 3X 24G OC', 350, '遊戲', 30.5, '微星', 54900),
('RTX3090 VISION OC 24G', 350, '遊戲', 32, '技嘉', 58990),
('RX 6700 XT EAGLE 12G', 230, '遊戲', 28.2, '技嘉', 22190),
('RX 6700 XT ELITE 12G', 230, '遊戲', 29.6, '技嘉', 24190),
('RX 6700 XT GAMING OC 12G', 230, '遊戲', 28.2, '技嘉', 23190),
('RX 6700 XT GAMING X 12G', 230, '遊戲', 27.9, '微星', 24900),
('RX 6700 XT MECH 2X 12G', 230, '遊戲', 24.7, '微星', 22900),
('RX 6800 GAMING X TRIO 16G', 250, '遊戲', 32.4, '微星', 28900),
('RX6800 GAMING OC 16G', 250, '遊戲', 28.6, '技嘉', 26590),
('RX6800XT GAMING OC 16G', 300, '遊戲', 28.6, '技嘉', 31290),
('RX6800XT GAMING X TRIO 16G', 300, '遊戲', 32.4, '微星', 33900),
('RX6900XT GAMING OC 16G', 300, '遊戲', 28.6, '技嘉', 49490),
('RX6900XT GAMING X TRIO 16G', 300, '遊戲', 32.4, '微星', 44900),
('TUF-GTX1650-O4GD6-GAMING', 75, '遊戲', 20.5, '華碩', 6190),
('TUF-GTX1650-O4GD6-P-GAMING', 75, '遊戲', 20.6, '華碩', 6190),
('TUF-GTX1650S-O4G-GAMING', 100, '遊戲', 20.6, '華碩', 6990),
('TUF-GTX1660-6G-GAMING', 120, '遊戲', 20.5, '華碩', 8690),
('TUF-GTX1660-O6G-GAMING', 120, '遊戲', 20.5, '華碩', 9490),
('TUF-GTX1660S-O6G-GAMING', 120, '遊戲', 20.6, '華碩', 10990),
('TUF-RTX3060-12G-GAMING', 170, '遊戲', 30.1, '華碩', 14690),
('TUF-RTX3060Ti-O8G-GAMING', 200, '遊戲', 30.1, '華碩', 18990),
('TUF-RTX3070-O8G-GAMING', 220, '遊戲', 30, '華碩', 21490),
('TUF-RTX3080-10G-GAMING', 320, '遊戲', 30, '華碩', 30590),
('TUF-RTX3090-24G-GAMING', 350, '遊戲', 30, '華碩', 52990),
('TUF-RX6700XT-O12G-GAMING', 230, '遊戲', 32.2, '華碩', 24990),
('TUF-RX6800-O16G-GAMING', 250, '遊戲', 31, '華碩', 27990),
('TUF-RX6800XT-O16G-GAMING', 300, '遊戲', 32, '華碩', 33990),
('TUF-RX6900XT-O16G-GAMING', 300, '遊戲', 32, '華碩', 44990),
('TURBO-RTX3070-8G', 220, '遊戲', 26.7, '華碩', 22490),
('TURBO-RTX3090-24G', 350, '遊戲', 26.8, '華碩', 59990);

-- --------------------------------------------------------

--
-- 資料表結構 `G_TDP`
--

CREATE TABLE `G_TDP` (
  `G_TDP` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `G_TDP`
--

INSERT INTO `G_TDP` (`G_TDP`) VALUES
(19),
(23),
(30),
(65),
(75),
(100),
(120),
(160),
(170),
(200),
(220),
(230),
(250),
(300),
(320),
(350);

-- --------------------------------------------------------

--
-- 資料表結構 `hdd`
--

CREATE TABLE `hdd` (
  `HDD_model` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `hdd`
--

INSERT INTO `hdd` (`HDD_model`, `brand`, `price`) VALUES
('1TB(32M7200轉/三年保)', 'Toshiba', 1230),
('1TB【新梭魚】(64M/72000/三年保)', 'Seagate', 1250),
('1TB【藍標】(64M/7200轉/三年保)', 'WD', 1250),
('1TB【黑標】(64M/7200轉/五年保)', 'WD', 2300),
('2TB(128M/5400轉/三年保)', 'Toshiba', 1630),
('2TB【新梭魚】(256M/7200轉/三年保)', 'Seagate', 1750),
('2TB【藍標】(256M/5400轉/三年保)', 'WD', 1650),
('2TB【藍標】(256M/7200轉/三年保)', 'WD', 1780),
('2TB【黑標】(64M/7200轉/五年保)', 'WD', 3450),
('3TB(64M/7200轉/三年)', 'Toshiba', 2350),
('3TB【新梭魚】(256M/5400轉/三年保)', 'Seagate', 2490),
('4TB(128M/5400轉/三年保)', 'Toshiba', 2750),
('4TB(128MM7200轉/三年保)', 'Toshiba', 3120),
('4TB【新梭魚】(256M/5400轉/三年保)', 'Seagate', 2800),
('4TB【藍標】 (256M/5400轉/三年保)', 'WD', 2850),
('4TB【黑標】(256M/7200轉/五年保)', 'WD', 5200),
('500G【黑標】(64M/7200轉/五年保)', 'WD', 1990),
('6TB(256M/7200轉/三年保)', 'Toshiba', 5100),
('6TB【新梭魚】(256M/5400轉/三年保)', 'Seagate', 4350),
('6TB【黑標】(256M/7200轉/五年保)', 'WD', 6850),
('8TB【新梭魚】(256M/5400萬/三年保)', 'Seagate', 5750);

-- --------------------------------------------------------

--
-- 資料表結構 `length`
--

CREATE TABLE `length` (
  `length` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `length`
--

INSERT INTO `length` (`length`) VALUES
(14.4),
(14.5),
(14.6),
(14.7),
(14.8),
(14.9),
(15),
(15.1),
(15.2),
(15.3),
(15.4),
(15.5),
(15.6),
(15.7),
(15.8),
(15.9),
(16),
(16.1),
(16.2),
(16.3),
(16.4),
(16.5),
(16.6),
(16.7),
(16.8),
(16.9),
(17),
(17.1),
(17.2),
(17.3),
(17.4),
(17.5),
(17.6),
(17.7),
(17.8),
(17.9),
(18),
(18.1),
(18.2),
(18.3),
(18.4),
(18.5),
(18.6),
(18.7),
(18.8),
(18.9),
(19),
(19.1),
(19.2),
(19.3),
(19.4),
(19.5),
(19.6),
(19.7),
(19.8),
(19.9),
(20),
(20.1),
(20.2),
(20.3),
(20.4),
(20.5),
(20.6),
(20.7),
(20.8),
(20.9),
(21),
(21.1),
(21.2),
(21.3),
(21.4),
(21.5),
(21.6),
(21.7),
(21.8),
(21.9),
(22),
(22.1),
(22.2),
(22.3),
(22.4),
(22.5),
(22.6),
(22.7),
(22.8),
(22.9),
(23),
(23.1),
(23.2),
(23.3),
(23.4),
(23.5),
(23.6),
(23.7),
(23.8),
(23.9),
(24),
(24.1),
(24.2),
(24.3),
(24.4),
(24.5),
(24.6),
(24.7),
(24.8),
(24.9),
(25),
(25.1),
(25.2),
(25.3),
(25.4),
(25.5),
(25.6),
(25.7),
(25.8),
(25.9),
(26),
(26.1),
(26.2),
(26.3),
(26.4),
(26.5),
(26.6),
(26.7),
(26.8),
(26.9),
(27),
(27.1),
(27.2),
(27.3),
(27.4),
(27.5),
(27.6),
(27.7),
(27.8),
(27.9),
(28),
(28.1),
(28.2),
(28.3),
(28.4),
(28.5),
(28.6),
(28.7),
(28.8),
(28.9),
(29),
(29.1),
(29.2),
(29.3),
(29.4),
(29.5),
(29.6),
(29.7),
(29.8),
(29.9),
(30),
(30.1),
(30.2),
(30.3),
(30.4),
(30.5),
(30.6),
(30.7),
(30.8),
(30.9),
(31),
(31.1),
(31.2),
(31.3),
(31.4),
(31.5),
(31.6),
(31.7),
(31.8),
(31.9),
(32),
(32.1),
(32.2),
(32.3),
(32.4),
(32.5),
(32.6),
(32.7),
(32.8),
(32.9),
(33),
(33.1),
(33.2),
(33.3),
(33.4),
(33.5),
(33.6),
(33.7),
(33.8),
(33.9),
(34),
(34.1),
(34.2),
(34.3),
(34.4),
(34.5),
(34.6),
(34.7),
(34.8),
(34.9),
(35),
(35.1),
(35.2),
(35.3),
(35.4),
(35.5),
(35.6),
(35.7),
(35.8),
(35.9),
(36),
(36.1),
(36.2),
(36.3),
(36.4),
(36.5),
(36.6),
(36.7),
(36.8),
(36.9),
(37),
(37.1),
(37.2),
(37.3),
(37.4),
(37.5),
(37.6),
(37.7),
(37.8),
(37.9),
(38),
(38.1),
(38.2),
(38.3),
(38.4),
(38.5),
(38.6),
(38.7),
(38.8),
(38.9),
(39),
(39.1),
(39.2),
(39.3),
(39.4),
(39.5),
(39.6),
(39.7),
(39.8),
(39.9),
(40),
(40.1),
(40.2),
(40.3),
(40.4),
(40.5),
(40.6),
(40.7),
(40.8),
(40.9),
(41),
(41.1),
(41.2),
(41.3),
(41.4),
(41.5),
(41.6),
(41.7),
(41.8),
(41.9),
(42),
(42.1),
(42.2),
(42.3);

-- --------------------------------------------------------

--
-- 資料表結構 `mb`
--

CREATE TABLE `mb` (
  `M_model` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `socket` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `size` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `R_slot` int(10) NOT NULL,
  `S_slot` int(10) NOT NULL,
  `P_slot` int(10) NOT NULL,
  `R_capacity` int(10) NOT NULL,
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `price` int(10) NOT NULL,
  `propose` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `mb`
--

INSERT INTO `mb` (`M_model`, `socket`, `size`, `R_slot`, `S_slot`, `P_slot`, `R_capacity`, `brand`, `price`, `propose`) VALUES
('A520 AORUS ELITE', 'AM4', 'ATX', 4, 4, 2, 128, '技嘉', 3290, '文書'),
('A520M AORUS ELITE', 'AM4', 'M-ATX', 4, 4, 1, 128, '技嘉', 2790, '文書'),
('A520M DS3H', 'AM4', 'M-ATX', 4, 4, 1, 128, '技嘉', 2490, '文書'),
('A520M PRO-C DASH', 'AM4', 'M-ATX', 4, 4, 1, 128, '微星', 2490, '文書'),
('A520M S2H', 'AM4', 'M-ATX', 4, 4, 1, 128, '技嘉', 2290, '文書'),
('A520M VECTOR WIFI', 'AM4', 'M-ATX', 4, 4, 1, 128, '微星', 2790, '文書'),
('A520M-A PRO', 'AM4', 'M-ATX', 4, 4, 1, 128, '微星', 2090, '文書'),
('B450M AORUS ELITE 翼力特', 'AM4', 'M-ATX', 4, 6, 2, 128, '技嘉', 2590, '遊戲'),
('B450M GAMING', 'AM4', 'M-ATX', 4, 4, 1, 128, '技嘉', 1990, '遊戲'),
('B450M MORTAR-迫擊砲 MAX', 'AM4', 'M-ATX', 4, 4, 2, 128, '微星', 2190, '遊戲'),
('B450M PRO-VDH MAX', 'AM4', 'M-ATX', 4, 4, 1, 128, '微星', 2490, '遊戲'),
('B450M S2H', 'AM4', 'M-ATX', 4, 4, 1, 128, '技嘉', 1890, '遊戲'),
('B450M-A PRO MAX', 'AM4', 'M-ATX', 4, 4, 1, 128, '微星', 2090, '遊戲'),
('B460M DS3H V2', '1200_400', 'M-ATX', 4, 4, 2, 64, '技嘉', 3190, '遊戲'),
('B550 AORUS ELITE', 'AM4', 'ATX', 4, 4, 3, 128, '技嘉', 4790, '遊戲'),
('B550 AORUS MASTER', 'AM4', 'ATX', 4, 6, 3, 128, '技嘉', 8690, '遊戲'),
('B550 AORUS PRO AC', 'AM4', 'ATX', 4, 6, 3, 128, '技嘉', 5290, '遊戲'),
('B550 GAMING CARBON WIFI', 'AM4', 'ATX', 4, 6, 2, 128, '微星', 5990, '遊戲'),
('B550 GAMING EDGE WIFI', 'AM4', 'ATX', 4, 6, 2, 128, '微星', 5590, '遊戲'),
('B550 GAMING PLUS', 'AM4', 'ATX', 4, 6, 2, 128, '微星', 4690, '遊戲'),
('B550 GAMING X', 'AM4', 'ATX', 4, 4, 2, 128, '技嘉', 4090, '遊戲'),
('B550 UNIFY-X', 'AM4', 'ATX', 4, 6, 4, 128, '微星', 8990, '遊戲'),
('B550 VISION D', 'AM4', 'ATX', 4, 4, 3, 128, '技嘉', 7990, '遊戲'),
('B550-A PRO', 'AM4', 'ATX', 4, 6, 2, 128, '微星', 3990, '遊戲'),
('B550M AORUS ELITE', 'AM4', 'M-ATX', 4, 4, 2, 128, '技嘉', 3790, '遊戲'),
('B550M AORUS PRO', 'AM4', 'M-ATX', 4, 4, 2, 128, '技嘉', 3990, '遊戲'),
('B550M AORUS PRO-P', 'AM4', 'M-ATX', 4, 4, 2, 128, '技嘉', 3990, '遊戲'),
('B550M BAZOOKA', 'AM4', 'M-ATX', 4, 4, 1, 128, '微星', 3790, '遊戲'),
('B550M DS3H', 'AM4', 'M-ATX', 4, 4, 2, 128, '技嘉', 3090, '遊戲'),
('B550M GAMING', 'AM4', 'M-ATX', 4, 4, 1, 128, '技嘉', 3290, '遊戲'),
('B550M MORTAR', 'AM4', 'M-ATX', 4, 6, 2, 128, '微星', 4290, '遊戲'),
('B550M MORTAR WIFI', 'AM4', 'M-ATX', 4, 6, 2, 128, '微星', 4990, '遊戲'),
('B550M PRO', 'AM4', 'M-ATX', 4, 4, 1, 128, '微星', 2790, '遊戲'),
('B550M PRO-VDH', 'AM4', 'M-ATX', 4, 4, 1, 128, '微星', 3190, '遊戲'),
('B550M PRO-VDH WIFI', 'AM4', 'M-ATX', 4, 4, 1, 128, '微星', 3290, '遊戲'),
('B550M S2H', 'AM4', 'M-ATX', 4, 4, 1, 128, '技嘉', 2790, '遊戲'),
('B560 AORUS PRO AX', '1200_500', 'ATX', 4, 6, 3, 128, '技嘉', 5490, '遊戲'),
('B560 HD3', '1200_500', 'ATX', 4, 6, 2, 128, '技嘉', 4990, '遊戲'),
('B560 TOMAHAWK WIFI', '1200_500', 'ATX', 4, 6, 2, 128, '微星', 5490, '遊戲'),
('B560 TORPEDO', '1200_500', 'ATX', 4, 6, 2, 128, '微星', 4890, '遊戲'),
('B560M AORUS ELITE【獨家菁英】', '1200_500', 'M-ATX', 4, 6, 2, 128, '技嘉', 3890, '遊戲'),
('B560M AORUS PRO', '1200_500', 'M-ATX', 4, 6, 2, 128, '技嘉', 4290, '遊戲'),
('B560M AORUS PRO AX', '1200_500', 'M-ATX', 4, 6, 2, 128, '技嘉', 4790, '遊戲'),
('B560M BAZOOKA', '1200_500', 'M-ATX', 4, 6, 1, 128, '微星', 3790, '遊戲'),
('B560M BOMBER(爆破彈)', '1200_500', 'M-ATX', 4, 6, 1, 128, '微星', 2990, '遊戲'),
('B560M D3H', '1200_500', 'M-ATX', 4, 6, 2, 128, '技嘉', 3290, '遊戲'),
('B560M DS3H AC', '1200_500', 'M-ATX', 4, 6, 1, 128, '技嘉', 3890, '遊戲'),
('B560M GAMING HD', '1200_500', 'M-ATX', 4, 4, 1, 128, '技嘉', 2990, '遊戲'),
('B560M MORTAR', '1200_500', 'M-ATX', 4, 6, 2, 128, '微星', 4790, '遊戲'),
('B560M MORTAR WIFI', '1200_500', 'M-ATX', 4, 6, 2, 128, '微星', 4990, '遊戲'),
('B560M PRO-E', '1200_500', 'M-ATX', 4, 4, 1, 128, '微星', 2990, '遊戲'),
('B560M PRO-VDH', '1200_500', 'M-ATX', 4, 6, 1, 128, '微星', 3090, '遊戲'),
('B560M PRO-VDH WIFI', '1200_500', 'M-ATX', 4, 6, 1, 128, '微星', 3290, '遊戲'),
('H410M H V2', '1200_400', 'M-ATX', 4, 4, 1, 64, '技嘉', 2490, '文書'),
('H410M S2 V2', '1200_400', 'M-ATX', 4, 4, 1, 64, '技嘉', 2190, '文書'),
('H410M S2H V2', '1200_400', 'M-ATX', 4, 4, 1, 64, '技嘉', 2690, '文書'),
('H510M BOMBER', '1200_500', 'M-ATX', 4, 4, 1, 128, '微星', 2490, '文書'),
('H510M H', '1200_500', 'M-ATX', 4, 4, 1, 128, '技嘉', 2690, '文書'),
('H510M PRO', '1200_500', 'M-ATX', 4, 4, 1, 128, '微星', 2690, '文書'),
('H510M S2', '1200_500', 'M-ATX', 4, 4, 1, 128, '技嘉', 2490, '文書'),
('H510M S2H', '1200_500', 'M-ATX', 4, 4, 1, 128, '技嘉', 2890, '文書'),
('H510M-A PRO', '1200_500', 'M-ATX', 4, 4, 1, 128, '微星', 2540, '文書'),
('MPG X570 GAMING EDGE WIFI', 'AM4', 'ATX', 4, 6, 2, 128, '微星', 5990, '遊戲'),
('MPG X570 GAMING PLUS', 'AM4', 'ATX', 4, 6, 2, 128, '微星', 5590, '遊戲'),
('PRIME A520M-E', 'AM4', 'M-ATX', 4, 4, 1, 128, '華碩', 2490, '文書'),
('PRIME A520M-K', 'AM4', 'M-ATX', 4, 4, 1, 128, '華碩', 2390, '文書'),
('PRIME B450M-A II', 'AM4', 'M-ATX', 4, 6, 1, 128, '華碩', 2090, '遊戲'),
('PRIME B450M-K', 'AM4', 'M-ATX', 4, 4, 1, 128, '華碩', 1890, '遊戲'),
('PRIME B460M-A', '1200_400', 'M-ATX', 4, 6, 1, 64, '華碩', 2990, '遊戲'),
('PRIME B550-PLUS', 'AM4', 'ATX', 4, 6, 2, 128, '華碩', 3790, '遊戲'),
('PRIME B550M-A(WIFI)', 'AM4', 'M-ATX', 4, 4, 1, 128, '華碩', 3490, '遊戲'),
('PRIME B560M-A', '1200_500', 'M-ATX', 4, 6, 2, 128, '華碩', 3190, '遊戲'),
('PRIME B560M-K', '1200_500', 'M-ATX', 4, 6, 1, 128, '華碩', 2990, '遊戲'),
('PRIME H410M-E', '1200_400', 'M-ATX', 4, 4, 1, 64, '華碩', 2490, '文書'),
('PRIME H410M-K', '1200_400', 'M-ATX', 4, 4, 1, 64, '華碩', 2390, '文書'),
('PRIME H510M-E', '1200_500', 'M-ATX', 4, 4, 1, 128, '華碩', 2690, '文書'),
('PRIME H510M-K', '1200_500', 'M-ATX', 4, 4, 1, 128, '華碩', 2590, '文書'),
('PRIME H570M-PLUS', '1200_500', 'M-ATX', 4, 6, 2, 128, '華碩', 4490, '遊戲'),
('PRIME TRX40-PRO S', 'TRX40', 'ATX', 8, 8, 3, 256, '華碩', 14990, '伺服器'),
('PRIME X299 DELUXE II', '2066', 'ATX', 8, 8, 3, 256, '華碩', 15990, '伺服器'),
('PRIME X299-A II', '2066', 'ATX', 8, 8, 3, 256, '華碩', 11990, '伺服器'),
('PRIME X570-P', 'AM4', 'ATX', 4, 6, 2, 128, '華碩', 4490, '遊戲'),
('PRIME Z590-A', '1200_500', 'ATX', 4, 6, 3, 128, '華碩', 7990, '遊戲'),
('PRIME Z590-P', '1200_500', 'ATX', 4, 4, 2, 128, '華碩', 5490, '遊戲'),
('PRIME Z590M-PLUS', '1200_500', 'M-ATX', 4, 5, 2, 128, '華碩', 4990, '遊戲'),
('Pro WS WRX80E-SAGE SE WIFI', 'WRX80', 'E-ATX', 8, 8, 7, 256, '華碩', 34990, '伺服器'),
('Pro WS X570-ACE', 'AM4', 'ATX', 4, 4, 3, 128, '華碩', 9990, '遊戲'),
('ROG CROSSHAIR VIII DARK HERO', 'AM4', 'ATX', 4, 8, 3, 128, '華碩', 15990, '遊戲'),
('ROG CROSSHAIR VIII FORMULA', 'AM4', 'ATX', 4, 8, 3, 128, '華碩', 19990, '遊戲'),
('ROG CROSSHAIR VIII HERO(WI-FI)', 'AM4', 'ATX', 4, 8, 3, 128, '華碩', 12990, '遊戲'),
('ROG MAXIMUS XIII APEX', '1200_500', 'ATX', 4, 8, 2, 128, '華碩', 13990, '遊戲'),
('ROG MAXIMUS XIII HERO', '1200_500', 'ATX', 4, 6, 3, 128, '華碩', 15990, '遊戲'),
('ROG RAMPAGE VI EXTREME Encore', '2066', 'E-ATX', 8, 8, 3, 256, '華碩', 22990, '伺服器'),
('ROG STRIX B550-A GAMING', 'AM4', 'ATX', 4, 6, 2, 128, '華碩', 4790, '遊戲'),
('ROG STRIX B550-E GAMING', 'AM4', 'ATX', 4, 6, 3, 128, '華碩', 6990, '遊戲'),
('ROG STRIX B550-F GAMING(WIFI)', 'AM4', 'ATX', 4, 6, 2, 128, '華碩', 5490, '遊戲'),
('ROG STRIX B550-XE GAMING WIFI', 'AM4', 'ATX', 4, 6, 3, 128, '華碩', 8990, '遊戲'),
('ROG STRIX B560-A GAMING WIFI', '1200_500', 'ATX', 4, 6, 2, 128, '華碩', 4990, '遊戲'),
('ROG STRIX B560-F GAMING WIFI', '1200_500', 'ATX', 4, 6, 2, 128, '華碩', 5490, '遊戲'),
('ROG STRIX B560-G GAMING WIFI', '1200_500', 'M-ATX', 4, 6, 2, 128, '華碩', 4790, '遊戲'),
('ROG STRIX TRX40-XE GAMING', 'TRX40', 'ATX', 8, 8, 3, 256, '華碩', 17990, '遊戲'),
('ROG STRIX X299-E GAMING II', '2066', 'ATX', 8, 8, 3, 256, '華碩', 13990, '伺服器'),
('ROG STRIX X570-E GAMING', 'AM4', 'ATX', 4, 8, 3, 128, '華碩', 9990, '遊戲'),
('ROG STRIX X570-F GAMING', 'AM4', 'ATX', 4, 8, 3, 128, '華碩', 7990, '遊戲'),
('ROG STRIX Z590-A GAMING WIFI', '1200_500', 'ATX', 4, 6, 3, 128, '華碩', 9990, '遊戲'),
('ROG STRIX Z590-E GAMING WIFI', '1200_500', 'ATX', 4, 6, 3, 128, '華碩', 12990, '遊戲'),
('ROG STRIX Z590-F GAMING WIFI', '1200_500', 'ATX', 4, 6, 3, 128, '華碩', 10990, '遊戲'),
('ROG ZENITH II EXTREME ALPHA', 'TRX40', 'E-ATX', 8, 8, 3, 256, '華碩', 32990, '伺服器'),
('TUF GAMING A520M-PLUS', 'AM4', 'M-ATX', 4, 4, 1, 128, '華碩', 2790, '文書'),
('TUF GAMING B450-PLUS II', 'AM4', 'ATX', 4, 6, 2, 128, '華碩', 2990, '遊戲'),
('TUF GAMING B450M-PLUS II', 'AM4', 'M-ATX', 4, 6, 2, 128, '華碩', 2190, '遊戲'),
('TUF GAMING B550-PLUS', 'AM4', 'ATX', 4, 6, 2, 128, '華碩', 4790, '遊戲'),
('TUF GAMING B550M-PLUS', 'AM4', 'M-ATX', 4, 4, 2, 128, '華碩', 3990, '遊戲'),
('TUF GAMING B550M-PLUS(WIFI)', 'AM4', 'M-ATX', 4, 4, 2, 128, '華碩', 4690, '遊戲'),
('TUF GAMING B550M-ZAKU 薩克(WI-FI)', 'AM4', 'M-ATX', 4, 4, 2, 128, '華碩', 5190, '遊戲'),
('TUF GAMING B560-PLUS WIFI', '1200_500', 'ATX', 4, 6, 2, 128, '華碩', 4490, '遊戲'),
('TUF GAMING B560M-E', '1200_500', 'M-ATX', 4, 6, 2, 128, '華碩', 3390, '遊戲'),
('TUF GAMING B560M-PLUS', '1200_500', 'M-ATX', 4, 6, 2, 128, '華碩', 3490, '遊戲'),
('TUF GAMING B560M-PLUS WIFI', '1200_500', 'M-ATX', 4, 6, 2, 128, '華碩', 3990, '遊戲'),
('TUF GAMING H570-PRO WIFI', '1200_500', 'ATX', 4, 6, 2, 128, '華碩', 5490, '遊戲'),
('TUF GAMING X570-PLUS', 'AM4', 'ATX', 4, 8, 2, 128, '華碩', 5290, '遊戲'),
('TUF GAMING X570-PLUS WI-FI', 'AM4', 'ATX', 4, 8, 2, 128, '華碩', 5990, '遊戲'),
('TUF GAMING X570-PRO(WIFI)', 'AM4', 'ATX', 4, 8, 2, 128, '華碩', 6990, '遊戲'),
('TUF Z590-PLUS GAMING【獨家TUF】', '1200_500', 'ATX', 4, 6, 2, 128, '華碩', 6490, '遊戲'),
('WS X299 PRO/SE', '2066', 'ATX', 8, 6, 4, 256, '華碩', 13700, '伺服器'),
('X299 UD4 Pro', '2066', 'ATX', 8, 8, 5, 256, '技嘉', 10690, '伺服器'),
('X299X AORUS MASTER', '2066', 'E-ATX', 8, 8, 4, 256, '技嘉', 14490, '伺服器'),
('X299X DESIGNARE 10G', '2066', 'E-ATX', 8, 8, 4, 256, '技嘉', 19990, '伺服器'),
('X570 AORUS ELITE', 'AM4', 'ATX', 4, 6, 2, 128, '技嘉', 4990, '遊戲'),
('X570 AORUS ELITE WIFI', 'AM4', 'ATX', 4, 6, 2, 128, '技嘉', 5590, '遊戲'),
('X570 AORUS MASTER', 'AM4', 'ATX', 4, 6, 3, 128, '技嘉', 11800, '遊戲'),
('X570 GAMING X', 'AM4', 'ATX', 4, 6, 2, 128, '技嘉', 4890, '遊戲'),
('X570-A PRO', 'AM4', 'ATX', 4, 6, 2, 128, '微星', 4990, '遊戲'),
('Z590 ACE', '1200_500', 'ATX', 4, 6, 3, 128, '微星', 15990, '遊戲'),
('Z590 AORUS ELITE', '1200_500', 'ATX', 4, 6, 2, 128, '技嘉', 6490, '遊戲'),
('Z590 AORUS ELITE AX', '1200_500', 'ATX', 4, 6, 2, 128, '技嘉', 6990, '遊戲'),
('Z590 AORUS MASTER', '1200_500', 'ATX', 4, 6, 3, 128, '技嘉', 15990, '遊戲'),
('Z590 AORUS PRO AX', '1200_500', 'ATX', 4, 6, 3, 128, '技嘉', 9990, '遊戲'),
('Z590 AORUS TACHYON', '1200_500', 'ATX', 4, 8, 4, 128, '技嘉', 16490, '遊戲'),
('Z590 AORUS XTREME', '1200_500', 'E-ATX', 4, 6, 3, 128, '技嘉', 24990, '遊戲'),
('Z590 GAMING CARBON WIFI', '1200_500', 'ATX', 4, 6, 3, 128, '微星', 10490, '遊戲'),
('Z590 GAMING EDGE WIFI', '1200_500', 'ATX', 4, 6, 3, 128, '微星', 9990, '遊戲'),
('Z590 GAMING PLUS', '1200_500', 'ATX', 4, 6, 3, 128, '微星', 7990, '遊戲'),
('Z590 GAMING X【獨家】', '1200_500', 'ATX', 4, 6, 2, 128, '技嘉', 5690, '遊戲'),
('Z590 GODLIKE', '1200_500', 'E-ATX', 4, 6, 2, 128, '微星', 24990, '遊戲'),
('Z590 PRO WIFI', '1200_500', 'ATX', 4, 6, 2, 128, '微星', 5390, '遊戲'),
('Z590 TOMAHAWK WIFI', '1200_500', 'ATX', 4, 6, 2, 128, '微星', 6490, '遊戲'),
('Z590 VISION G', '1200_500', 'ATX', 4, 6, 3, 128, '技嘉', 7990, '遊戲'),
('Z590-A PRO', '1200_500', 'ATX', 4, 6, 2, 128, '微星', 5290, '遊戲'),
('Z590M GAMING X', '1200_500', 'M-ATX', 4, 6, 2, 128, '技嘉', 4990, '遊戲');

-- --------------------------------------------------------

--
-- 資料表結構 `menu`
--

CREATE TABLE `menu` (
  `M_ID` int(50) NOT NULL,
  `cpu` varchar(50) COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `mb` varchar(50) COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `gpu` varchar(50) COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `ram` varchar(50) COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `C_case` varchar(50) COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `psu` varchar(50) COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `HDD` varchar(50) COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `SSD` varchar(50) COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `cooler` varchar(50) COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `cpu_num` int(11) DEFAULT NULL,
  `mb_num` int(11) DEFAULT NULL,
  `gpu_num` int(11) DEFAULT NULL,
  `ram_num` int(11) DEFAULT NULL,
  `case_num` int(11) DEFAULT NULL,
  `psu_num` int(11) DEFAULT NULL,
  `HDD_num` int(11) DEFAULT NULL,
  `SSD_num` int(11) DEFAULT NULL,
  `cooler_num` int(11) DEFAULT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `menu`
--

INSERT INTO `menu` (`M_ID`, `cpu`, `mb`, `gpu`, `ram`, `C_case`, `psu`, `HDD`, `SSD`, `cooler`, `cpu_num`, `mb_num`, `gpu_num`, `ram_num`, `case_num`, `psu_num`, `HDD_num`, `SSD_num`, `cooler_num`, `total`) VALUES
(2, 'TR PRO 3995WX', 'Pro WS WRX80E-SAGE SE WIFI', '', '金士頓16GB 3200MHz DDR4 ECC CL22 DIMM 2R*8 Hynix D(KS', 'Montech Air 900 Mesh', '振華 冰山金蝶 400W', '2TB【新梭魚】(256M/7200轉/三年保)', 'Blue 4TB(藍標)/2.5吋/讀:560M/寫:530M/3D TLC顆粒(五年保)', 'NH-U9 TR4-SP3 Y8', 1, 1, 0, 3, 1, 1, 2, 4, 1, 279470);

-- --------------------------------------------------------

--
-- 資料表結構 `mg_brand`
--

CREATE TABLE `mg_brand` (
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `mg_brand`
--

INSERT INTO `mg_brand` (`brand`) VALUES
('EVGA'),
('微星'),
('技嘉'),
('華碩');

-- --------------------------------------------------------

--
-- 資料表結構 `propose`
--

CREATE TABLE `propose` (
  `propose` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `propose`
--

INSERT INTO `propose` (`propose`) VALUES
('伺服器'),
('文書'),
('遊戲');

-- --------------------------------------------------------

--
-- 資料表結構 `psu`
--

CREATE TABLE `psu` (
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `P_watt` int(10) NOT NULL,
  `P_model` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `psu`
--

INSERT INTO `psu` (`brand`, `P_watt`, `P_model`, `price`) VALUES
('全漢', 2000, '全漢 CANNON 2000W', 12900),
('全漢', 1000, '全漢 HYDRO G PRO 1000W', 5290),
('全漢', 650, '全漢 HYDRO G PRO 650W', 3190),
('全漢', 750, '全漢 HYDRO G PRO 750W', 3490),
('全漢', 850, '全漢 HYDRO G PRO 850W', 3990),
('全漢', 1000, '全漢 HYDRO PTM PRO 1000W', 6990),
('全漢', 1200, '全漢 HYDRO PTM PRO 1200W', 7990),
('全漢', 650, '全漢 HYDRO PTM PRO 650W', 3990),
('全漢', 750, '全漢 HYDRO PTM PRO 750W', 4290),
('全漢', 850, '全漢 HYDRO PTM PRO 850W', 4990),
('全漢', 1200, '全漢 HYDRO PTM+ 1200W', 19990),
('全漢', 350, '全漢 聖武士 350W', 990),
('全漢', 450, '全漢 聖武士 450W', 1490),
('全漢', 550, '全漢 聖武士 550W', 1790),
('全漢', 650, '全漢 聖武士 650W', 1990),
('全漢', 550, '全漢 金鋼彈 550W', 3290),
('全漢', 650, '全漢 金鋼彈 650W', 3890),
('全漢', 750, '全漢 金鋼彈 750W', 4590),
('全漢', 850, '全漢 金鋼彈 850W', 5190),
('全漢', 550, '全漢 黑爵士D 550W', 2090),
('全漢', 650, '全漢 黑爵士D 650W', 2590),
('全漢', 550, '全漢 黑爵士II Hydro GE 550W', 2490),
('全漢', 650, '全漢 黑爵士II Hydro GE 650W', 2790),
('振華', 400, '振華 BRONZE KING 400W', 1190),
('振華', 450, '振華 BRONZE KING 450W', 1390),
('振華', 550, '振華 BRONZE KING 550W', 1790),
('振華', 550, '振華 LEADEX 550W', 2390),
('振華', 650, '振華 LEADEX 650W', 2690),
('振華', 750, '振華 LEADEX 750W', 3090),
('振華', 850, '振華 LEADEX 850W', 4090),
('振華', 550, '振華 LEADEX III 550W', 2590),
('振華', 650, '振華 LEADEX III 650W', 2890),
('振華', 750, '振華 LEADEX III 750W', 3290),
('振華', 850, '振華 LEADEX III 850W', 3790),
('振華', 550, '振華 LEADEX III ARGB 550W', 2690),
('振華', 650, '振華 LEADEX III ARGB 650W', 3090),
('振華', 750, '振華 LEADEX III ARGB 750W', 3490),
('振華', 850, '振華 LEADEX III ARGB 850W', 3990),
('振華', 1000, '振華 LEADEX SE 1000W', 5490),
('振華', 1200, '振華 LEADEX SE 1200W', 6690),
('振華', 400, '振華 冰山金蝶 400W', 1590),
('振華', 450, '振華 冰山金蝶 450W', 1790),
('振華', 500, '振華 冰山金蝶 500W', 1990),
('海韻', 550, '海韻 FOCUS GM-550(550W)', 2290),
('海韻', 650, '海韻 FOCUS GM-650(650W)', 2590),
('海韻', 750, '海韻 FOCUS GM-750(750W)', 2890),
('海韻', 1000, '海韻 FOCUS GX-1000(1000W)', 5090),
('海韻', 550, '海韻 FOCUS GX-550(550W)', 2690),
('海韻', 650, '海韻 FOCUS GX-650(650W)', 3090),
('海韻', 750, '海韻 FOCUS GX-750(750W)', 3390),
('海韻', 850, '海韻 FOCUS GX-850(850W)', 3890),
('海韻', 550, '海韻 FOCUS PX-550(550W)', 3490),
('海韻', 650, '海韻 FOCUS PX-650(650W)', 3890),
('海韻', 750, '海韻 FOCUS PX-750(750W)', 4290),
('海韻', 850, '海韻 FOCUS PX-850(850W)', 4790),
('海韻', 500, '海韻 FOCUS SGX-500(500W)', 3690),
('海韻', 650, '海韻 FOCUS SGX-650(650W)', 4790),
('海韻', 1000, '海韻 PRIME GX-1000(1000W)', 6890),
('海韻', 1300, '海韻 PRIME GX-1300(1300W)', 8490),
('海韻', 750, '海韻 PRIME GX-750(750W)', 4990),
('海韻', 850, '海韻 PRIME GX-850(850W)', 5790),
('海韻', 1000, '海韻 PRIME PX-1000(1000W)', 7990),
('海韻', 1300, '海韻 PRIME PX-1300(1300W)', 9390),
('海韻', 650, '海韻 PRIME PX-650(650W)', 4990),
('海韻', 750, '海韻 PRIME PX-750(750W)', 5790),
('海韻', 850, '海韻 PRIME PX-850(850W)', 6890),
('海韻', 550, '海韻 PRIME SSR-550PD(550W)', 2690),
('海韻', 650, '海韻 PRIME SSR-650TR(650W)', 6090),
('海韻', 1000, '海韻 PRIME TX-1000(1000W)', 9790),
('海韻', 750, '海韻 PRIME TX-750(750W)', 6890),
('海韻', 850, '海韻 PRIME TX-850(850W)', 8090);

-- --------------------------------------------------------

--
-- 資料表結構 `psu_brand`
--

CREATE TABLE `psu_brand` (
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `psu_brand`
--

INSERT INTO `psu_brand` (`brand`) VALUES
('全漢'),
('振華'),
('海韻');

-- --------------------------------------------------------

--
-- 資料表結構 `PS_slot`
--

CREATE TABLE `PS_slot` (
  `slot` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `PS_slot`
--

INSERT INTO `PS_slot` (`slot`) VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8);

-- --------------------------------------------------------

--
-- 資料表結構 `P_watt`
--

CREATE TABLE `P_watt` (
  `P_watt` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `P_watt`
--

INSERT INTO `P_watt` (`P_watt`) VALUES
(350),
(400),
(450),
(500),
(550),
(650),
(750),
(850),
(1000),
(1200),
(1300),
(2000);

-- --------------------------------------------------------

--
-- 資料表結構 `ram`
--

CREATE TABLE `ram` (
  `R_model` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `R_capacity` int(10) NOT NULL,
  `propose` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `hz` int(10) NOT NULL,
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `ram`
--

INSERT INTO `ram` (`R_model`, `R_capacity`, `propose`, `hz`, `brand`, `price`) VALUES
('UMAX 16GB DDR4-2400', 16, '文書', 2400, 'UMAX', 1990),
('UMAX 16GB DDR4-2666', 16, '文書', 2666, 'UMAX', 2150),
('UMAX 16GB DDR4-3200', 16, '遊戲', 3200, 'UMAX', 2250),
('UMAX 32GB DDR4-3200', 32, '遊戲', 3200, 'UMAX', 4450),
('UMAX 8GB DDR4-2400', 8, '文書', 2400, 'UMAX', 1100),
('UMAX 8GB DDR4-2666', 8, '文書', 2666, 'UMAX', 1100),
('UMAX 8GB DDR4-3200', 8, '遊戲', 3200, 'UMAX', 1200),
('金士頓 16GB DDR4-2666', 16, '文書', 2666, '金士頓', 2350),
('金士頓 16GB DDR4-3200', 16, '遊戲', 3200, '金士頓', 2450),
('金士頓 16GB DDR4-3200 H F', 16, '遊戲', 3200, '金士頓', 2550),
('金士頓 32GB DDR4-3200', 32, '遊戲', 3200, '金士頓', 4750),
('金士頓 8GB DDR4-2400', 8, '文書', 2400, '金士頓', 1200),
('金士頓 8GB DDR4-2666', 8, '遊戲', 2666, '金士頓', 1250),
('金士頓 8GB DDR4-3200', 8, '遊戲', 3200, '金士頓', 1250),
('金士頓16GB 2666MHz D4 ECC Reg CL19 DIMM 2R*8 Hynix D(', 16, '伺服器', 2666, '金士頓', 2788),
('金士頓16GB 3200MHz D4 ECC Reg CL22 DIMM 1R*8 Micron E', 16, '伺服器', 3200, '金士頓', 2888),
('金士頓16GB 3200MHz DDR4 ECC CL22 DIMM 2R*8 Hynix D(KS', 16, '伺服器', 3200, '金士頓', 2700),
('金士頓32GB 2666MHz D4 ECC Reg CL19 DIMM 2R*4 Micron E', 32, '伺服器', 2666, '金士頓', 4990),
('金士頓32GB 3200MHz D4 ECC Reg CL22 DIMM 1R*4 Micron E', 32, '伺服器', 3200, '金士頓', 5100),
('金士頓32GB 3200MHz DDR4 ECC CL22 DIMM 2R*8 Micron E(K', 32, '伺服器', 3200, '金士頓', 4800),
('金士頓8GB 2666MHz DDR4 ECC CL19 DIMM 1R*8 Hynix D(KSM', 8, '伺服器', 2666, '金士頓', 1400),
('金士頓8GB 2666MHz DDR4 ECC Reg CL19 DIMM 1R*8 Micron ', 8, '伺服器', 2666, '金士頓', 1600);

-- --------------------------------------------------------

--
-- 資料表結構 `ram_brand`
--

CREATE TABLE `ram_brand` (
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `ram_brand`
--

INSERT INTO `ram_brand` (`brand`) VALUES
('UMAX'),
('金士頓');

-- --------------------------------------------------------

--
-- 資料表結構 `ram_hz`
--

CREATE TABLE `ram_hz` (
  `hz` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `ram_hz`
--

INSERT INTO `ram_hz` (`hz`) VALUES
(2400),
(2666),
(3200);

-- --------------------------------------------------------

--
-- 資料表結構 `R_capacity`
--

CREATE TABLE `R_capacity` (
  `R_capacity` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `R_capacity`
--

INSERT INTO `R_capacity` (`R_capacity`) VALUES
(8),
(16),
(32),
(64),
(128),
(256);

-- --------------------------------------------------------

--
-- 資料表結構 `R_slot`
--

CREATE TABLE `R_slot` (
  `R_slot` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `R_slot`
--

INSERT INTO `R_slot` (`R_slot`) VALUES
(4),
(8);

-- --------------------------------------------------------

--
-- 資料表結構 `size`
--

CREATE TABLE `size` (
  `size` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `size`
--

INSERT INTO `size` (`size`) VALUES
('ATX'),
('E-ATX'),
('M-ATX');

-- --------------------------------------------------------

--
-- 資料表結構 `socket`
--

CREATE TABLE `socket` (
  `socket` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `socket`
--

INSERT INTO `socket` (`socket`) VALUES
('1200_400'),
('1200_500'),
('2066'),
('AM4'),
('TRX40'),
('WRX80');

-- --------------------------------------------------------

--
-- 資料表結構 `ssd`
--

CREATE TABLE `ssd` (
  `SSD_model` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `ssd`
--

INSERT INTO `ssd` (`SSD_model`, `brand`, `price`) VALUES
('Blue 1TB(藍標)/2.5吋/讀:560M/寫:530M/3D TLC顆粒(五年保)', 'WD', 3100),
('Blue 250G(藍標)/2.5吋讀:545M/寫:525M/3D TLC顆粒(五年保)', 'WD', 1230),
('Blue 2TB(藍標)/2.5吋/讀:560M/寫:530M/3D TLC顆粒(五年保)', 'WD', 6650),
('Blue 4TB(藍標)/2.5吋/讀:560M/寫:530M/3D TLC顆粒(五年保)', 'WD', 14290),
('Blue 500G(藍標)/2.5吋/讀:545M/寫:525M/3D TLC顆粒(五年保)', 'WD', 1750),
('Crucial BX500 1TB/2.5吋讀:540M/寫:500M/TLC顆粒(三年保)', '美光', 2500),
('Crucial BX500 240G/2.5吋讀:540M/寫:500M/TLC顆粒(三年保)', '美光', 900),
('Crucial BX500 2TB/2.5吋/讀:540M/寫:500M/TLC顆粒(三年保)', '美光', 5699),
('Crucial BX500 480G/2.5吋/讀:540M/寫:500M/TLC顆粒(三年保)', '美光', 1480),
('Crucial MX500 1TB/2.5吋讀:560M/寫:510M/TLC/(五年保)', '美光', 2899),
('Crucial MX500 250G/2.5吋讀:560M/寫:510M/TLC/(五年保)', '美光', 1399),
('Crucial MX500 2TB/2.5吋/讀:560M/寫:510M/TLC/(五年保)', '美光', 6150),
('Crucial MX500 500G/2.5吋/讀:560M/寫:510M/TLC/(五年保)', '美光', 1750),
('Green 240G(綠標)/2.5吋/讀:540M/寫:430M/TLC顆粒(三年保)', 'WD', 980),
('Green 2TB(綠標)/2.5吋讀:540M/寫:430M/TLC顆粒(三年保)', 'WD', 5490),
('Green 480G(綠標)/2.5吋/讀:540M/寫:430M/TLC顆粒(三年保)', 'WD', 1588),
('Samsung 860 PRO 1TB/2.5吋讀:560/寫:530/MLC/五年保', '三星', 6888),
('Samsung 860 PRO 512G/2.5吋讀:560/寫:530/MLC/五年保', '三星', 3488),
('Samsung 870 EVO 1TB/2.5吋/讀:550/寫:520/TLC/五年保', '三星', 3250),
('Samsung 870 EVO 250G/2.5吋讀:550/寫:520/TLC/五年保', '三星', 1399),
('Samsung 870 EVO 500G/2.5吋/讀:550/寫:520/TLC/五年保', '三星', 1799),
('Samsung 870 QVO 1TB/2.5吋讀:560/寫:530/QLC/三年保', '三星', 2699);

-- --------------------------------------------------------

--
-- 資料表結構 `storage_brand`
--

CREATE TABLE `storage_brand` (
  `brand` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- 傾印資料表的資料 `storage_brand`
--

INSERT INTO `storage_brand` (`brand`) VALUES
('Seagate'),
('Toshiba'),
('WD'),
('三星'),
('美光');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `agent`
--
ALTER TABLE `agent`
  ADD PRIMARY KEY (`brand`);

--
-- 資料表索引 `case_brand`
--
ALTER TABLE `case_brand`
  ADD PRIMARY KEY (`brand`);

--
-- 資料表索引 `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`cnumber`);

--
-- 資料表索引 `cooler`
--
ALTER TABLE `cooler`
  ADD PRIMARY KEY (`Co_model`),
  ADD KEY `brand` (`brand`),
  ADD KEY `socket` (`socket`);

--
-- 資料表索引 `cooler_brand`
--
ALTER TABLE `cooler_brand`
  ADD PRIMARY KEY (`brand`);

--
-- 資料表索引 `cpu`
--
ALTER TABLE `cpu`
  ADD PRIMARY KEY (`CPU_model`),
  ADD KEY `socket` (`socket`),
  ADD KEY `propose` (`propose`),
  ADD KEY `CPU_TDP` (`CPU_TDP`),
  ADD KEY `brand` (`brand`);

--
-- 資料表索引 `cpu_brand`
--
ALTER TABLE `cpu_brand`
  ADD PRIMARY KEY (`brand`);

--
-- 資料表索引 `CPU_TDP`
--
ALTER TABLE `CPU_TDP`
  ADD PRIMARY KEY (`CPU_TDP`);

--
-- 資料表索引 `c_case`
--
ALTER TABLE `c_case`
  ADD PRIMARY KEY (`Ca_model`),
  ADD KEY `size` (`size`),
  ADD KEY `brand` (`brand`),
  ADD KEY `length` (`length`);

--
-- 資料表索引 `gpu`
--
ALTER TABLE `gpu`
  ADD PRIMARY KEY (`G_model`),
  ADD KEY `G_TDP` (`G_TDP`),
  ADD KEY `propose` (`propose`),
  ADD KEY `brand` (`brand`),
  ADD KEY `length` (`length`);

--
-- 資料表索引 `G_TDP`
--
ALTER TABLE `G_TDP`
  ADD PRIMARY KEY (`G_TDP`);

--
-- 資料表索引 `hdd`
--
ALTER TABLE `hdd`
  ADD PRIMARY KEY (`HDD_model`),
  ADD KEY `brand` (`brand`);

--
-- 資料表索引 `length`
--
ALTER TABLE `length`
  ADD PRIMARY KEY (`length`);

--
-- 資料表索引 `mb`
--
ALTER TABLE `mb`
  ADD PRIMARY KEY (`M_model`),
  ADD KEY `propose` (`propose`),
  ADD KEY `brand` (`brand`),
  ADD KEY `R_capacity` (`R_capacity`),
  ADD KEY `size` (`size`),
  ADD KEY `socket` (`socket`),
  ADD KEY `P_slot` (`P_slot`),
  ADD KEY `R_slot` (`R_slot`),
  ADD KEY `S_slot` (`S_slot`);

--
-- 資料表索引 `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`M_ID`);

--
-- 資料表索引 `mg_brand`
--
ALTER TABLE `mg_brand`
  ADD PRIMARY KEY (`brand`);

--
-- 資料表索引 `propose`
--
ALTER TABLE `propose`
  ADD PRIMARY KEY (`propose`);

--
-- 資料表索引 `psu`
--
ALTER TABLE `psu`
  ADD PRIMARY KEY (`P_model`),
  ADD KEY `P_watt` (`P_watt`),
  ADD KEY `brand` (`brand`);

--
-- 資料表索引 `psu_brand`
--
ALTER TABLE `psu_brand`
  ADD PRIMARY KEY (`brand`);

--
-- 資料表索引 `PS_slot`
--
ALTER TABLE `PS_slot`
  ADD PRIMARY KEY (`slot`);

--
-- 資料表索引 `P_watt`
--
ALTER TABLE `P_watt`
  ADD PRIMARY KEY (`P_watt`);

--
-- 資料表索引 `ram`
--
ALTER TABLE `ram`
  ADD PRIMARY KEY (`R_model`),
  ADD KEY `brand` (`brand`),
  ADD KEY `hz` (`hz`),
  ADD KEY `R_capacity` (`R_capacity`),
  ADD KEY `propose` (`propose`);

--
-- 資料表索引 `ram_brand`
--
ALTER TABLE `ram_brand`
  ADD PRIMARY KEY (`brand`);

--
-- 資料表索引 `ram_hz`
--
ALTER TABLE `ram_hz`
  ADD PRIMARY KEY (`hz`);

--
-- 資料表索引 `R_capacity`
--
ALTER TABLE `R_capacity`
  ADD PRIMARY KEY (`R_capacity`);

--
-- 資料表索引 `R_slot`
--
ALTER TABLE `R_slot`
  ADD PRIMARY KEY (`R_slot`);

--
-- 資料表索引 `size`
--
ALTER TABLE `size`
  ADD PRIMARY KEY (`size`);

--
-- 資料表索引 `socket`
--
ALTER TABLE `socket`
  ADD PRIMARY KEY (`socket`);

--
-- 資料表索引 `ssd`
--
ALTER TABLE `ssd`
  ADD PRIMARY KEY (`SSD_model`),
  ADD KEY `brand` (`brand`);

--
-- 資料表索引 `storage_brand`
--
ALTER TABLE `storage_brand`
  ADD PRIMARY KEY (`brand`);

--
-- 在傾印的資料表使用自動增長(AUTO_INCREMENT)
--

--
-- 使用資料表自動增長(AUTO_INCREMENT) `menu`
--
ALTER TABLE `menu`
  MODIFY `M_ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- 已傾印資料表的限制(constraint)
--

--
-- 資料表的限制(constraint) `cooler`
--
ALTER TABLE `cooler`
  ADD CONSTRAINT `cooler_ibfk_1` FOREIGN KEY (`brand`) REFERENCES `cooler_brand` (`brand`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cooler_ibfk_2` FOREIGN KEY (`socket`) REFERENCES `socket` (`socket`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制(constraint) `cpu`
--
ALTER TABLE `cpu`
  ADD CONSTRAINT `cpu_ibfk_1` FOREIGN KEY (`socket`) REFERENCES `socket` (`socket`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cpu_ibfk_2` FOREIGN KEY (`propose`) REFERENCES `propose` (`propose`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cpu_ibfk_3` FOREIGN KEY (`CPU_TDP`) REFERENCES `CPU_TDP` (`CPU_TDP`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cpu_ibfk_4` FOREIGN KEY (`brand`) REFERENCES `cpu_brand` (`brand`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制(constraint) `c_case`
--
ALTER TABLE `c_case`
  ADD CONSTRAINT `c_case_ibfk_1` FOREIGN KEY (`size`) REFERENCES `size` (`size`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `c_case_ibfk_2` FOREIGN KEY (`brand`) REFERENCES `case_brand` (`brand`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `c_case_ibfk_3` FOREIGN KEY (`length`) REFERENCES `length` (`length`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制(constraint) `gpu`
--
ALTER TABLE `gpu`
  ADD CONSTRAINT `gpu_ibfk_1` FOREIGN KEY (`G_TDP`) REFERENCES `G_TDP` (`G_TDP`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `gpu_ibfk_2` FOREIGN KEY (`propose`) REFERENCES `propose` (`propose`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `gpu_ibfk_3` FOREIGN KEY (`brand`) REFERENCES `mg_brand` (`brand`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `gpu_ibfk_4` FOREIGN KEY (`length`) REFERENCES `length` (`length`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制(constraint) `hdd`
--
ALTER TABLE `hdd`
  ADD CONSTRAINT `hdd_ibfk_1` FOREIGN KEY (`brand`) REFERENCES `storage_brand` (`brand`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制(constraint) `mb`
--
ALTER TABLE `mb`
  ADD CONSTRAINT `mb_ibfk_1` FOREIGN KEY (`propose`) REFERENCES `propose` (`propose`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `mb_ibfk_2` FOREIGN KEY (`brand`) REFERENCES `mg_brand` (`brand`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `mb_ibfk_3` FOREIGN KEY (`R_capacity`) REFERENCES `R_capacity` (`R_capacity`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `mb_ibfk_4` FOREIGN KEY (`size`) REFERENCES `size` (`size`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `mb_ibfk_5` FOREIGN KEY (`socket`) REFERENCES `socket` (`socket`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `mb_ibfk_6` FOREIGN KEY (`P_slot`) REFERENCES `PS_slot` (`slot`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `mb_ibfk_7` FOREIGN KEY (`R_slot`) REFERENCES `R_slot` (`R_slot`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `mb_ibfk_8` FOREIGN KEY (`S_slot`) REFERENCES `PS_slot` (`slot`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制(constraint) `psu`
--
ALTER TABLE `psu`
  ADD CONSTRAINT `psu_ibfk_1` FOREIGN KEY (`P_watt`) REFERENCES `P_watt` (`P_watt`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `psu_ibfk_2` FOREIGN KEY (`brand`) REFERENCES `psu_brand` (`brand`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制(constraint) `ram`
--
ALTER TABLE `ram`
  ADD CONSTRAINT `ram_ibfk_1` FOREIGN KEY (`brand`) REFERENCES `ram_brand` (`brand`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ram_ibfk_2` FOREIGN KEY (`hz`) REFERENCES `ram_hz` (`hz`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ram_ibfk_3` FOREIGN KEY (`R_capacity`) REFERENCES `R_capacity` (`R_capacity`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ram_ibfk_4` FOREIGN KEY (`propose`) REFERENCES `propose` (`propose`) ON UPDATE CASCADE;

--
-- 資料表的限制(constraint) `ssd`
--
ALTER TABLE `ssd`
  ADD CONSTRAINT `ssd_ibfk_1` FOREIGN KEY (`brand`) REFERENCES `storage_brand` (`brand`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
