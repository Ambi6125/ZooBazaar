-- phpMyAdmin SQL Dump
-- version 4.9.3
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Gegenereerd op: 11 okt 2022 om 11:06
-- Serverversie: 5.7.26-log
-- PHP-versie: 7.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbi468695`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `accounts`
--

CREATE TABLE `accounts` (
  `username` varchar(20) NOT NULL,
  `salt_used` varchar(60) DEFAULT NULL,
  `hashed_password` varchar(512) DEFAULT NULL,
  `isAdmin` tinyint(1) DEFAULT NULL,
  `isBlocked` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `accounts`
--

INSERT INTO `accounts` (`username`, `salt_used`, `hashed_password`, `isAdmin`, `isBlocked`) VALUES
('A', 'SUYQNVTIICRXIJBASWXSWBGEDXUBBAHPKGYTFMUCBKKSMNNDJXVVDTSQNTNP', '1A8DD51D3E3A02B27BBB6D2988E5AF4254553D09D48F655C94642A0B9E419431D638E415D0EA05288B4C8E86D1E88704BE3D68DB7039AD92D7B92E50405C37B8', 0, 0),
('Abc', 'GMNRFWOMRRBQJBJPFSUQIDYCOXWQERTNOIMFBIBOXEEBKUACWKYFLNUDNKDH', 'F1A3A0AF9C5056184FFBCBB47A11BDE944BBD49BDF064488DFBD8906CA6CA1BCAE819A89CFF476E9433EA2ECCC59D2BB8A34327C68D403A391D4A78A7CBBC457', 0, 0),
('Abcd', 'SALEUIQWKWGQEMKMUCOVSAHFGDCUVEJPYGTTVYTBDMHGWRNTXNMYJICRSGXQ', 'BA212819A330F4D41EFC7A80F9D3EFBC61E63ECD0B4204635BA42D69A00D66B490AB1B2E28AA9341462B7CAD917A6190F21F541EF3911C7D80E363CD9D4E764D', 0, 0),
('Abcde', 'UJPQVWYAXVIHROKMTWOYOXKJEWGVUKNFLQTFBFBMRUYNFTFQRSRXCONVXFMX', 'DFBDD9C30600E2D2F103AF4E028C90765FD035AB815E74B771B64372E55EB67FEF6AF3BBAC46920CBADC527B7CA5E09E1D742109008A94DC5C70800C69E92915', 0, 0),
('Amogus', 'LPYFGUUJKNXKHEJPJRLRCDTQSEWQKRAHNQGXPFTLKQGSFXQCHJHBGNTIVHLC', '7BFED291362323BEF3CF984577A0C8A3D33ECBE4523FAFED6437E72F42F27A66245A4705BCF55DF28C0C59A197E02BFD72F14B11537ACBF77EEEC3B3D3B55CC6', 0, 0),
('Gaia', 'QPEJDWLPNTFCKMXYPHJNXDQHHNOMPJXTEHJUUSDPTYEIAIQSMIYPDJSMXWCP', 'C9C5C9B7A9C9200F2D417AC510E86F1A5B88097A54C7CEAAF7CEA74A86DB2F06A2C17875AFD4DEBEB2FAF8B15479F17C0F0AC498D94C1A24A2D492C560E25CC4', 0, 0),
('LucasBussygaming', 'PAXNEDDSJECPEFQSLORCFEWWFFUDEVAUEGRHQQCLCIWHDCRYPMTWIRQLCAHX', '0A74759C5C77E437802733FE42C8B061DE8450983D27F90E253FAE3688F821FBE4DD5FAFFE194C6911EE3EA775DB8FE60B53E223156935B3321D7C0FF681BB06', 1, 0),
('Luna', 'WEWNCKTNIPOPYLAILFWSIEIMBKYCRWQYBGBPDFBGQQNGHAWLFUEUEKNRUKLR', 'E385D1A197E783606F1DB124E9E8925296F6011D1C26396F4E1696694DC139635BAF9F59A3F9A45CD7A3B2C42A3E29E01D5B950BDD4C749ED2D2FCC1D6C85C28', 0, 0),
('MaoZedong', 'FKUVWFEDHOEAMNSHOKOXJPMRPGACXLSDDLYLKEFOVSJTLEVFMHSPDNKPWDFQ', '5469F26C2D0546EB8E19125134EEA2ACE1A6602C678C6E036C240B82AA5FB41DE76A565EC8C64E7E2A83B4AF9290C24093294E678D36F722D5B7643B5325405D', 1, 0),
('Napoleon', 'VFWBQUVHTBLJGOWCVMDXKUJMTNKSRLCYXPDSXFXLYSCSPCALVIFPWLXAVJHC', 'C6E7EA32F7E84DFA3E68D0ED82595B187C86C392873AC26C63E15DFA85FEF3812A7CA80A36B0A6ABEA55BBC7E837B2D28DFA2F3F73B48DEBF2C197F0E8734063', 0, 0),
('Peter Parker', 'XUOTEWEEHPEODWOJHLWPPMMESKDJGHCGUFTNVIUOKPHSEOMYXFNBVVOLIJAS', 'F43392FCBF06664EC8D3AA5A49EEC7DF0E4E644981B2B109F1F30ED916282DAF0CB92187532C3CBBB7D057B4E33220732F807B3509B77B59158F06CDC26E3538', 0, 0),
('RedCrewmate', 'IANWWLLXXESINHNPAIWRJHAHPYPBOMXKIOLMFAPNKBRVREYVYRQBUBGBAFHW', 'B6ED9E132384B321C08F5510A8B9A3F9E26C6B3A6518FF7E62350D3F1F73E3FE245EC03AA69BEC92C3107AE66C0270FA06799E3B4EC2929C2AE5DAE4AC7DA2D2', 0, 0),
('test', 'FMJODFNWWMILSBJVREWAKEKEEFTHLPJBPJDMYTUSIGHDXVLLMGSOFPWABEJW', 'AB9B29F99019C94CBD032B87D4F513B32E36769457B97FF5211DE28A62BF7CE966CE9989E8C4DBB959E9FB4368DF969339195418393710B97B83E4BEFAA0C6E5', 0, 0),
('TestAcc', 'POKNLYGBFQHFRDLDJYANNIBRLODJVNKGKMQHKEFABKCHWBDIHJAWMKLHMRCW', '292A983BBF31E14F056208FA3FCB96A0B6736CEDD120D1E52C1B3854383DA0EFBAC8831AB3E856B2EF6E7677FC9C4ED9128EE32546CEEF1BB03F5F978F18C7AC', 0, 0),
('TheMoonShinesBright', 'DFIHEMKDATYNGFRUQAELNGAXXRYFPTMENXDNFJCGARFVFCMQYBVJPKWWEJJM', '021663D332DE3AEAF78E226B9B3E20CBDE275B005E4A4210E9CC32BF4AA75706D3C8ACE0900F5E510B7B88E62C1A5D7161A6EA892424B2A9BAEFF3BF67B553B4', 0, 0),
('xWildlife', 'JUHHMBGNPQAFIITBNOTRQDUWPARKFDIXSKGPJWAHQOQHATTQQFIKXFRFYJRL', '5D016B193C44FD4D0FA8538295442800446E0F01D8C11E3A5570FE3D8B8D26AC7C3FFDC9564F5125DD4BC7B58BFEDBE1E42EB3A9FA6417668DBCE5D17C3E347F', 0, 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `artworks`
--

CREATE TABLE `artworks` (
  `id` int(11) NOT NULL,
  `title` varchar(20) DEFAULT NULL,
  `description` varchar(60) DEFAULT NULL,
  `poster` varchar(20) DEFAULT NULL,
  `post_time` datetime DEFAULT NULL,
  `likes` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `artworks`
--

INSERT INTO `artworks` (`id`, `title`, `description`, `poster`, `post_time`, `likes`) VALUES
(1, 'Happy little trees', 'Test', 'Napoleon', '2022-04-12 00:00:00', 3),
(2, 'Waterloo', 'A big batte', 'Napoleon', '2022-04-12 00:00:00', 100),
(3, 'Xi Jinping Portrait', 'Like for social credit', 'MaoZedong', '1989-06-03 15:06:48', 1402000000),
(4, NULL, NULL, NULL, NULL, NULL),
(5, 'Thié-ri Bao Deî', 'Bing chilling', 'MaoZedong', '1945-06-19 13:06:31', 3456787),
(6, 'Mo-na li-san', 'She has no eyebrows', 'MaoZedong', '2022-04-22 00:00:00', 69420),
(7, 'Sus', 'Electrical', 'RedCrewmate', '2001-11-09 00:00:00', 400),
(8, 'A', 'a', 'A', '0001-01-01 00:00:00', 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `comments`
--

CREATE TABLE `comments` (
  `text` varchar(120) DEFAULT NULL,
  `poster` varchar(20) DEFAULT NULL,
  `post_time` datetime DEFAULT NULL,
  `likes` int(11) DEFAULT NULL,
  `parent_post_id` int(11) DEFAULT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `sys_matches`
--

CREATE TABLE `sys_matches` (
  `id` int(11) NOT NULL,
  `tournament` int(11) NOT NULL,
  `playerOne` int(11) NOT NULL,
  `playerTwo` int(11) NOT NULL,
  `scoreOne` int(11) DEFAULT NULL,
  `scoreTwo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `sys_matches`
--

INSERT INTO `sys_matches` (`id`, `tournament`, `playerOne`, `playerTwo`, `scoreOne`, `scoreTwo`) VALUES
(1, 11, 1, 2, 21, 16),
(2, 11, 1, 3, NULL, NULL),
(3, 11, 1, 4, 29, 30),
(4, 11, 2, 1, NULL, NULL),
(5, 11, 2, 3, NULL, NULL),
(6, 11, 2, 4, 1, 21),
(7, 11, 3, 1, NULL, NULL),
(8, 11, 3, 2, NULL, NULL),
(9, 11, 3, 4, NULL, NULL),
(10, 11, 4, 1, NULL, NULL),
(11, 11, 4, 2, NULL, NULL),
(12, 11, 4, 3, NULL, NULL),
(13, 14, 1, 2, 21, 18),
(14, 14, 2, 1, NULL, NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `sys_players`
--

CREATE TABLE `sys_players` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `salt` varchar(60) NOT NULL,
  `hashedPassword` varchar(512) NOT NULL,
  `emailAdress` varchar(100) NOT NULL,
  `gender` set('male','female') DEFAULT NULL,
  `wins` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `sys_players`
--

INSERT INTO `sys_players` (`id`, `username`, `firstName`, `lastName`, `salt`, `hashedPassword`, `emailAdress`, `gender`, `wins`) VALUES
(1, 'UnknownGuy21', 'John', 'Doe', 'BHQKJECJMNXECXFVARCNMMABJNWHKVUUNPPSGQDFBAHNFNKAEPLGTVHOGPBU', '723144105352A6560BAB7F5B87F862F2D62E174458B10552275677BEA596B59124926E1371F4FC579F9722234A590DA522FA2D951410DB956CA48503F88650EC', 'johndoe@gmail.com', 'male', 0),
(2, 'UnknownGirl22', 'Jane', 'Doe', 'CJHSDLGAUNXKQLWOYHXGEYCIQXKWARTHXNCOFDYCTARKUDDCQSMDYTOCGYCE', '9746098D62D76ADF21ABB4FADB06A7F6D34D4A7DAD3FDCD72D8A497E3464AD4EB1078FC528A23EA48C1CA332D1278386921E711BD4D6432DF24B9DAD96955178', 'janedoe@gmail.com', 'female', 0),
(3, 'LucasGaming', 'Lucas', 'Weijs', 'IWWQMVCRUDJDIPSNOKAPAQPSEMVPGXAWKBEVCDEOUACYMYWATAQTSPIQGDMA', 'AA2046E40680F16D41894565F8BD26CC6657EF6A1C02EFA78549B6054295C4566C6C1979F4A66B4134A28966E98B6C31DD02C2AF7998FC2CE43028DAB3E0C800', 'lucasweijs@shemail.com', 'male', 0),
(4, 'Get_Excited', 'Iasonas', 'Karnaros Witkamp', 'WNATTVKPSHEIMIONOEYIOEFCYCMDUGIWIATFYMUCQXQWLIJCVJYTWCSSIXTQ', 'B93E4CAA319DF413E7AFC752A0DD917A81750CEC2D609110A416F3DAF1CE31AD0C1833A73F9EF0C51BF107431A40D5D37658072B068627F5CC1F83A6273E3C39', 'NotAFurry@shemail.com', 'male', 0),
(5, 'Witte Erik', 'Eric', 'De Wit', 'APLFCJVHPTOXCLVBJFTOUCISFWGSQBTNXFVFCRSOPGTREEPBXPRMDXQWHRYF', '03B745DEBA4E7B25C698BA2EA03AA4BEA8E173C1EF7CB04C26903657A7FF85FADB8DE4B254FBCABDD3DAAD6B564E63EC413FC8C72695B4EF8F7A64C0DD82721D', 'Erik@gmail.com', 'male', 0),
(6, 'Ambi', 'Yannick', 'Gorissen', 'AFACUCOWDOFGFQGUFIUIENACOQFLNPMKKGFMATCUXHJYCMBTREACIHUUKXDP', '22FBF5214E3ECB6FFECA8600827E42FEDD3825BB00F272AEF43B33C2827A6C1FF8A1B14C0771891C62302264761A1ACFC7B6017DDCA02675436EA9E72B995F88', 'yannick.gorissen@home.nl', 'male', 0),
(7, 'sus', 'sussus', 'amogus', 'RSVCLNVVXKUUGNXSAFWSISATTNERFVAQUHQLLOXLARGKHFEQHSSPWHNHNIVM', 'ED7FEF80B6F747A827C8C78EA302D70D5439F1FE3227800B9B4B5BC7C6B36DCB615186BEEC10CE0ED6DC925E264A5E0807095526BD00EF630E2F8CCBB01B6C0D', 'sussy@baptiste.cum', 'male', 0),
(9, 'demo', 'Demo', 'Demo', 'MYTSHPHHCFNICVJHKEHGJVQLLIXOXLLMDAPREOVLEBKNKHXUUWWOGDFPPGKI', 'D6E57D41C4B2529938D64B4FA352B20C75A2AB6B30EC45C333BA42B55D838823ACAE07314ED69E08F6E88CA87B5C429265E50E79BEE4837550000E70AA02ED96', 'demo@demo.nl', 'male', 0),
(10, 'Luna', 'Teodora', 'Chitas', 'OATPYDOTHQVYGQSACJSLEFGADVWRKUMBEDYUSJDQRMCBXTAQYNDKTSKIMPUL', 'EFB4CF34865B4920DA4CB62A0844816690982A58793B51FB91AAD18946B04E8BB302F9B6B82D6E44317FA6E757A2196C1CD48107CB2B1960EF3EC563C0708318', 'teodorachitas1@gmail.com', 'female', 0),
(11, 'hds', 'Henk', 'de Steen', 'AAIQUCBREJDXCTTNSNWXMQDMIHQMODIQGJDRJFHJAVBRPAKSFNOJBSHQNGLQ', '7F9596D9F33EBE8F5A161DF55805268526F57040A9EE1F01F1F49BFE07852962E0228B06EB9D85E652FA740E0F0E95D41DF5DBC98224A726183500F4053139C4', 'hds@gmail.com', 'male', 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `sys_playersports`
--

CREATE TABLE `sys_playersports` (
  `player_id` int(11) NOT NULL,
  `sport_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `sys_registrations`
--

CREATE TABLE `sys_registrations` (
  `playerID` int(11) DEFAULT NULL,
  `tournamentID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `sys_registrations`
--

INSERT INTO `sys_registrations` (`playerID`, `tournamentID`) VALUES
(1, 1),
(2, 1),
(4, 1),
(5, 1),
(3, 1),
(1, 2),
(2, 2),
(3, 2),
(4, 2),
(1, 11),
(2, 11),
(3, 11),
(4, 11),
(1, 14),
(2, 14);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `sys_sports`
--

CREATE TABLE `sys_sports` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `sys_staff`
--

CREATE TABLE `sys_staff` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `salt` varchar(60) NOT NULL,
  `hashed_password` varchar(512) NOT NULL,
  `emailAddress` varchar(100) NOT NULL,
  `gender` set('male','female') NOT NULL,
  `BSN` varchar(9) DEFAULT NULL,
  `nationality` varchar(100) DEFAULT NULL,
  `city` varchar(100) DEFAULT NULL,
  `postalCode` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `sys_staff`
--

INSERT INTO `sys_staff` (`id`, `username`, `firstName`, `lastName`, `salt`, `hashed_password`, `emailAddress`, `gender`, `BSN`, `nationality`, `city`, `postalCode`) VALUES
(1, 'Admin', 'Yan', 'Janssen', 'GAWPABMVEUGOVUQADHPEGKLLIRPEAFNLVFSWDFDXGXXPXKRFDXWCVVLPEPSD', '3593CEB9C22F226B7769DF61FE68461FF0C6805AF53B36DB268B60E20E53A930586385B09D131352E13C518A415BCE79C834BA94E7248A88D1F203465222B48B', 'j.janssen@gmail.com', 'male', '123456789', 'Dutch', 'Eindhoven', '1534DB'),
(2, 'Valkyrja', 'Freya', 'Odinsdottir', 'YTHFIFXKIXSYIRUCRGEGVWXLVLPHRYTWHHHQSQFVNKKJCVNKTTWETBEAJWCH', 'ABDB5BCE08F71ABFFC168A2D79F6241F7151F8CDBBC7427D5D9EC09EA7AB96103A9F7C2624609D414FF7B14C2AE3B5106880FEF87B821C46259A334B2E818BB4', 'Valhalla', 'female', '192837465', 'Norwegian', 'Bergen', '345678NN'),
(3, 'PenguinsAreCute', 'Hannah', 'Ackersham', 'PWJEEKWRFXYRQORWNMASQVXFAGWDBSEFEJATBYCRCHSRROCTPSQUWCYSKGPL', '948A2CF78A13CB043AF622F9AD2BE74D5E094236D47701151E8CF764A07E934DD5B9B737171C1C78B75DCEF1F6FF7B1C5195637D08F8956F4F1885087E3E0ECC', 'HA', 'female', '123321123', 'British', 'Worcestershire', 'WO1423'),
(4, 'Waahaa', 'Waluigi', 'Wario', 'XWWAWUKPEVTIPQOECYCNMHIKWIFBRRXBLQYFKQDXALCBJWIFFWJVDJRCOQKY', 'D05C8F020F12B3370BA98FA1C6610284A03A50F7DE11E14F0268F594986C7A6FE7092179A464A3E1670AE6F93713081FDE69E46F77D8A87610519D611AD0354E', 'Waluigi', 'male', '999999999', 'Italian', 'Rome', 'RO9276'),
(7, 'LucasWeijs', 'Lucas', 'Weijs', 'ENUAUYUEDGHSMIQBGHBXBDOJVHPUQLJCCECTQHETLSJMIDYHBBUCUJDJAWRB', '7B10AF1C9B5BA6A8EE9EDCFEB24D7614DC167EFC57E5B2BA075F40932C44046E3942C0DD76E18C0E44435029AA87654D9D3A6751CC42D0A8CED1A6D42799E035', 'lucas', 'female', '123456789', 'Dutch', 'Leunen', 'Gaymin23'),
(11, 'Amogus', 'Amon', 'Gus', 'HNQTWSQSGLLSHLJWVGJRSNNLTYYLPQIXDCOOAQMERSXOQAHAWBYUQXOHWTTG', 'C10CB81DA711750D83C2F0FD6FE0F19CF5CB17C6B1BAE8AA7ABF2F7E87BA8FA40796D2E85F7FAC73FD2046BA3BF027AB9293F84FA2D1B4B85087C3BAE30F2B44', 'Mogus', 'female', '123454321', 'Polus', 'The Skeld', '4M0GU5'),
(12, 'Wardruna', 'Einar', 'Selvik', 'AHEWGMKWBVWIWOVOOGXAQCWIIHRNQWXUJVLPYTOHUPFDODDDGYMECBEMRXXR', 'E786A8128B85C27E3A47BACB682B0E0BCA505CD65E197F9795C9AF54C0785B1F889361D02520A09EFA46EA6A120D97C322A9C589C82038D10E3D29D5EE9EB893', 'Lyfjaberg', 'male', '123456543', 'Norwegian', 'Bergen', 'BE2534'),
(13, 'Meli', 'Melda', 'Gumus', 'PGRFCPFSCANGWLFLQWYSLDWLRBPRHKKGOXNXDADBGTUXWCQTTNMHUCGLLTTQ', '223341773336BF92B0FA37AE524E657E024F7E01B5106C69192FFE48344668C07D43215C4D25A8847A58D54C5EE3A2FBD62F8A1A69271E98E572634467EB715A', '123', 'female', '123456789', 'Japanese', 'Oss', '5343HL'),
(14, 'Demo', 'demo', 'demo', 'VAKJIUBVTJMNVQDRMRLVXYOKRYJYLWLOITAGKMXGJGDVTODXYLGRHTXQLBCD', 'A6563E36E762930B0F2988D2AC471DDFD3E085D3955FD87F907A5FE548672FBD5B4420B20FCF78F669CAEAF6EBE4F0329B3AFAC202B8D3BD923A45AF6BC9C5D7', 'demo', 'male', '123456789', 'demo', 'demo', 'demo12'),
(15, 'luna', 'chitas', 'teodora', 'YGQENUUIMYWVIUBJKOGHSJKKIJWVURONPFTHCIUOCUHCKTGBDFEBBRVWHHKH', '086A52283CBE1D99B3BEA3623D9F2A17BEC0E2F9E66E5FAB3460A44D9D8E68BF36CE3BA27F0F57EB50AE2FE83DD7048B44F0155FED96949541E4E39D77CA3B93', 'yannick', 'female', '345655552', 'romanian', 'sittard', '6132sr');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `sys_tournaments`
--

CREATE TABLE `sys_tournaments` (
  `id` int(11) NOT NULL,
  `gameFormat` varchar(255) NOT NULL,
  `game` varchar(255) NOT NULL,
  `description` text,
  `startTime` datetime NOT NULL,
  `endTime` datetime NOT NULL,
  `minPlayers` int(11) NOT NULL,
  `maxPlayers` int(11) NOT NULL,
  `location` varchar(500) NOT NULL,
  `title` varchar(255) NOT NULL,
  `started` tinyint(1) NOT NULL DEFAULT '0',
  `scheduleSet` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `sys_tournaments`
--

INSERT INTO `sys_tournaments` (`id`, `gameFormat`, `game`, `description`, `startTime`, `endTime`, `minPlayers`, `maxPlayers`, `location`, `title`, `started`, `scheduleSet`) VALUES
(1, 'Round-Robin', 'Badminton', 'An exciting badminton tournament', '2022-06-11 12:00:00', '2022-07-11 12:00:00', 10, 30, 'Leunen, Steegse Peelweg 51', 'Our first tournament', 0, 0),
(2, 'Round-Robin', 'Football', 'All clubs from the south can compete here.', '2022-07-12 13:45:00', '2022-08-02 18:00:00', 4, 16, 'Eindhoven Philips stadion', 'Brabant championship', 0, 0),
(3, 'Round-Robin', 'Badminton', 'The biggest badminton event\nof Limburg! More information at:\nhttps://www.youtube.com/watch?v=dQw4w9WgXcQ', '2022-06-15 18:22:45', '2022-06-16 18:22:45', 2, 12, 'America, Limburg', 'Limburg Deathmatch', 0, 0),
(4, 'Round-Robin', 'Football', 'Not a real competition.\nJust baiting violent hooligans because it\'s funny.', '2022-06-15 20:25:54', '2022-06-16 20:25:54', 1, 100, 'Urk', 'Baiting hooligans', 0, 0),
(6, 'Round-Robin', 'Badminton', 'ICT festival', '2022-06-30 13:33:01', '2022-07-01 13:33:01', 2, 4, 'Rachelsmolen 1, Eindhoven', 'Fontys ICT', 0, 0),
(7, 'Round-Robin', 'Chess', 'Chessmasters continues with a second tournament!', '2022-07-21 14:11:48', '2022-08-12 14:11:48', 2, 18, 'Leunen, Steegse Peelweg 51', 'Chessmasters 2', 0, 0),
(8, 'Round-Robin', 'Tennis', 'Baby tennis balls', '2022-06-17 10:23:40', '2022-06-18 10:23:41', 1, 3, 'Basl', 'My first tennis game', 0, 0),
(10, 'Round-Robin', 'Chess', 'Chessmasters is back again', '2023-06-17 20:49:03', '2023-06-18 20:49:03', 10, 20, 'Amsterdam', 'Chessmasters 3', 0, 0),
(11, 'Round-Robin', 'Badminton', 'Test', '2022-06-10 22:21:00', '2022-06-18 12:00:00', 4, 5, 'Sittard', 'BadminTest', 0, 1),
(14, 'Round-Robin', 'Badminton', 'Use this for the demo', '2022-06-15 00:00:00', '2022-07-19 12:00:00', 2, 10, 'Eindhoven, Rachelsmolen 10', 'Demo tournament', 0, 1),
(15, 'Round-Robin', 'Chess', 'Demo', '2022-06-28 11:06:27', '2022-07-12 11:06:27', 2, 4, 'Demo', 'Demo', 0, 0),
(16, 'Round-Robin', 'Chess', 'Showcase tournaments', '2022-07-01 17:42:38', '2022-07-02 17:42:38', 2, 8, 'SIttard', 'Chussy', 0, 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `wdl_accounts`
--

CREATE TABLE `wdl_accounts` (
  `id` int(11) NOT NULL,
  `username` varchar(45) NOT NULL,
  `salt` varchar(45) NOT NULL,
  `password` varchar(512) NOT NULL,
  `email` varchar(60) NOT NULL,
  `accountType` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `wdl_grouptrips`
--

CREATE TABLE `wdl_grouptrips` (
  `tripId` int(11) NOT NULL,
  `minPeople` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `wdl_grouptrips`
--

INSERT INTO `wdl_grouptrips` (`tripId`, `minPeople`) VALUES
(1, 6);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `wdl_travelunits`
--

CREATE TABLE `wdl_travelunits` (
  `id` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `Accounts_id` int(11) NOT NULL,
  `tripId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `wdl_trips`
--

CREATE TABLE `wdl_trips` (
  `tripId` int(11) NOT NULL,
  `tripName` varchar(45) DEFAULT NULL,
  `description` text,
  `destination` varchar(45) DEFAULT NULL,
  `maxPeople` int(11) DEFAULT NULL,
  `startDate` date DEFAULT NULL,
  `endDate` date DEFAULT NULL,
  `tripType` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `wdl_trips`
--

INSERT INTO `wdl_trips` (`tripId`, `tripName`, `description`, `destination`, `maxPeople`, `startDate`, `endDate`, `tripType`) VALUES
(1, 'Fjord hiking', 'Join with a group and travel to the majestic fjords of western Norway!', 'Ålesund', 20, '2023-06-12', '2023-06-26', 1),
(7, 'Roman sightseeing', 'Go on a guided trip and see the full glory of ancient Rome!', 'Rome', 6, '2023-07-10', '2023-07-17', 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `zb_animals`
--

CREATE TABLE `zb_animals` (
  `id` int(11) NOT NULL,
  `animalName` varchar(50) DEFAULT NULL,
  `birthdate` datetime DEFAULT NULL,
  `species` int(11) DEFAULT NULL,
  `status` set('In zoo','Deceased','Transferred','Released') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `zb_animals`
--

INSERT INTO `zb_animals` (`id`, `animalName`, `birthdate`, `species`, `status`) VALUES
(1, 'Remus', '2014-07-16 00:00:00', 1, 'In zoo'),
(2, 'Luna', '2014-08-13 00:00:00', 1, 'In zoo'),
(3, 'Lupin', '2020-09-01 00:00:00', 1, 'In zoo'),
(4, 'Morbius', '2007-03-13 00:00:00', 1, 'Transferred'),
(5, 'Charlie', '2020-09-01 00:00:00', 1, 'In zoo'),
(6, 'Fenrir', '1753-01-01 00:00:00', 1, 'Deceased'),
(7, 'Akela', '2022-08-17 00:00:00', 1, 'In zoo'),
(8, 'Marty McFly', '2022-08-02 00:00:00', 5, 'Released'),
(9, 'Peter Pan', '2022-10-02 00:00:00', 7, 'Released'),
(10, 'malko kopele', '2022-03-10 00:00:00', 1, 'Released'),
(11, 'Gary', '2022-10-04 00:00:00', 11, 'In zoo'),
(12, 'Yannick', '1999-05-11 00:00:00', 12, 'Transferred');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `zb_exhibits`
--

CREATE TABLE `zb_exhibits` (
  `id` int(11) NOT NULL,
  `zone` varchar(50) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `capacity` int(11) DEFAULT NULL,
  `count` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `zb_exhibits`
--

INSERT INTO `zb_exhibits` (`id`, `zone`, `name`, `capacity`, `count`) VALUES
(1, 'Taiga', 'Wolves', 30, 1),
(6, 'Arctic', 'Penguins', 21, 0),
(7, 'Jungle', 'Monkeys', 49, 0),
(9, 'Desert', 'Small animals', 30, 0),
(10, 'Jungle', 'Tigers', 3, 0),
(11, 'Jungle', 'Herbivores', 6, 0),
(12, 'Arctic', 'Coastal animals', 23, 0),
(13, 'Taiga', 'Deer', 16, 0),
(14, 'Desert', 'Snakes', 2, 0),
(15, 'Jungle', 'Snakes', 5, 0),
(16, 'Arctic', 'Ocean', 30, 0),
(17, 'Jungle', 'Pandas and koalas', 20, 0),
(18, 'Taiga', 'Sea Eagle', 3, 0),
(19, 'Savannah', 'Herbivores', 0, 0),
(20, '', '<WASEMPTY>', 0, 0),
(21, 'Arctic', 'Zebreas and Giraffes', 2, 0),
(22, 'Desert', 'classroom', 30, 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `zb_food`
--

CREATE TABLE `zb_food` (
  `id` int(11) NOT NULL,
  `species` int(11) DEFAULT NULL,
  `foodDescription` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `zb_species`
--

CREATE TABLE `zb_species` (
  `id` int(11) NOT NULL,
  `speciesName` varchar(50) DEFAULT NULL,
  `scientificName` varchar(100) DEFAULT NULL,
  `exhibit` int(11) DEFAULT NULL,
  `unitSize` set('single','mass') DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `zb_species`
--

INSERT INTO `zb_species` (`id`, `speciesName`, `scientificName`, `exhibit`, `unitSize`, `quantity`) VALUES
(1, 'Grey Wolf', 'Canis Lupus', 1, 'single', 7),
(2, 'Puffin', 'Fratercula arctica', 12, 'single', 0),
(3, 'Red deer', 'Cervus elaphus', 13, 'single', 0),
(4, 'European fallow deer', 'Dama Dama', 13, 'single', 0),
(5, 'Horned rattlesnake', 'Crotalus Cerastes', 14, 'single', 1),
(6, 'Orca', 'Orcinus Orca', 16, 'single', 0),
(7, 'Sea Eagle', 'Haliaeetus Albicilla', 18, 'single', 1),
(8, 'name', 'asd', 1, 'single', 0),
(9, 'aasd', 'asd', 1, 'single', 0),
(10, 'Zebra', 'Equus Quaga', 19, 'single', 0),
(11, 'Fish', 'blub', 16, 'mass', 1),
(12, 'Human', 'Homo Sapiens', 22, 'single', 1);

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`username`);

--
-- Indexen voor tabel `artworks`
--
ALTER TABLE `artworks`
  ADD PRIMARY KEY (`id`),
  ADD KEY `poster` (`poster`);

--
-- Indexen voor tabel `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `poster` (`poster`),
  ADD KEY `parent_post_id` (`parent_post_id`);

--
-- Indexen voor tabel `sys_matches`
--
ALTER TABLE `sys_matches`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tournament` (`tournament`),
  ADD KEY `playerOne` (`playerOne`),
  ADD KEY `playerTwo` (`playerTwo`);

--
-- Indexen voor tabel `sys_players`
--
ALTER TABLE `sys_players`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `username_2` (`username`);

--
-- Indexen voor tabel `sys_playersports`
--
ALTER TABLE `sys_playersports`
  ADD KEY `player_id` (`player_id`),
  ADD KEY `sport_id` (`sport_id`);

--
-- Indexen voor tabel `sys_registrations`
--
ALTER TABLE `sys_registrations`
  ADD KEY `playerID` (`playerID`),
  ADD KEY `tournamentID` (`tournamentID`);

--
-- Indexen voor tabel `sys_sports`
--
ALTER TABLE `sys_sports`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `sys_staff`
--
ALTER TABLE `sys_staff`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexen voor tabel `sys_tournaments`
--
ALTER TABLE `sys_tournaments`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `wdl_accounts`
--
ALTER TABLE `wdl_accounts`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username_UNIQUE` (`username`);

--
-- Indexen voor tabel `wdl_grouptrips`
--
ALTER TABLE `wdl_grouptrips`
  ADD PRIMARY KEY (`tripId`);

--
-- Indexen voor tabel `wdl_travelunits`
--
ALTER TABLE `wdl_travelunits`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_TravelUnits_Accounts1_idx` (`Accounts_id`),
  ADD KEY `fk_TravelUnits_wdl_Trips1_idx` (`tripId`);

--
-- Indexen voor tabel `wdl_trips`
--
ALTER TABLE `wdl_trips`
  ADD PRIMARY KEY (`tripId`);

--
-- Indexen voor tabel `zb_animals`
--
ALTER TABLE `zb_animals`
  ADD PRIMARY KEY (`id`),
  ADD KEY `species` (`species`);

--
-- Indexen voor tabel `zb_exhibits`
--
ALTER TABLE `zb_exhibits`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `zb_food`
--
ALTER TABLE `zb_food`
  ADD PRIMARY KEY (`id`),
  ADD KEY `species` (`species`);

--
-- Indexen voor tabel `zb_species`
--
ALTER TABLE `zb_species`
  ADD PRIMARY KEY (`id`),
  ADD KEY `exhibit` (`exhibit`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `artworks`
--
ALTER TABLE `artworks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT voor een tabel `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `sys_matches`
--
ALTER TABLE `sys_matches`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT voor een tabel `sys_players`
--
ALTER TABLE `sys_players`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT voor een tabel `sys_staff`
--
ALTER TABLE `sys_staff`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT voor een tabel `sys_tournaments`
--
ALTER TABLE `sys_tournaments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT voor een tabel `wdl_accounts`
--
ALTER TABLE `wdl_accounts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `wdl_travelunits`
--
ALTER TABLE `wdl_travelunits`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `wdl_trips`
--
ALTER TABLE `wdl_trips`
  MODIFY `tripId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT voor een tabel `zb_animals`
--
ALTER TABLE `zb_animals`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT voor een tabel `zb_exhibits`
--
ALTER TABLE `zb_exhibits`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT voor een tabel `zb_food`
--
ALTER TABLE `zb_food`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `zb_species`
--
ALTER TABLE `zb_species`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `artworks`
--
ALTER TABLE `artworks`
  ADD CONSTRAINT `artworks_ibfk_1` FOREIGN KEY (`poster`) REFERENCES `accounts` (`username`);

--
-- Beperkingen voor tabel `comments`
--
ALTER TABLE `comments`
  ADD CONSTRAINT `comments_ibfk_1` FOREIGN KEY (`poster`) REFERENCES `accounts` (`username`),
  ADD CONSTRAINT `comments_ibfk_2` FOREIGN KEY (`parent_post_id`) REFERENCES `artworks` (`id`);

--
-- Beperkingen voor tabel `sys_matches`
--
ALTER TABLE `sys_matches`
  ADD CONSTRAINT `sys_matches_ibfk_1` FOREIGN KEY (`tournament`) REFERENCES `sys_tournaments` (`id`),
  ADD CONSTRAINT `sys_matches_ibfk_2` FOREIGN KEY (`playerOne`) REFERENCES `sys_players` (`id`),
  ADD CONSTRAINT `sys_matches_ibfk_3` FOREIGN KEY (`playerTwo`) REFERENCES `sys_players` (`id`);

--
-- Beperkingen voor tabel `sys_playersports`
--
ALTER TABLE `sys_playersports`
  ADD CONSTRAINT `sys_playersports_ibfk_1` FOREIGN KEY (`player_id`) REFERENCES `sys_players` (`id`),
  ADD CONSTRAINT `sys_playersports_ibfk_2` FOREIGN KEY (`sport_id`) REFERENCES `sys_sports` (`id`);

--
-- Beperkingen voor tabel `sys_registrations`
--
ALTER TABLE `sys_registrations`
  ADD CONSTRAINT `sys_registrations_ibfk_1` FOREIGN KEY (`playerID`) REFERENCES `sys_players` (`id`),
  ADD CONSTRAINT `sys_registrations_ibfk_2` FOREIGN KEY (`tournamentID`) REFERENCES `sys_tournaments` (`id`);

--
-- Beperkingen voor tabel `wdl_grouptrips`
--
ALTER TABLE `wdl_grouptrips`
  ADD CONSTRAINT `wdl_grouptrips_ibfk_1` FOREIGN KEY (`tripId`) REFERENCES `wdl_trips` (`tripId`);

--
-- Beperkingen voor tabel `wdl_travelunits`
--
ALTER TABLE `wdl_travelunits`
  ADD CONSTRAINT `fk_TravelUnits_Accounts1` FOREIGN KEY (`Accounts_id`) REFERENCES `wdl_accounts` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TravelUnits_wdl_Trips1` FOREIGN KEY (`tripId`) REFERENCES `wdl_trips` (`tripId`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Beperkingen voor tabel `zb_animals`
--
ALTER TABLE `zb_animals`
  ADD CONSTRAINT `zb_animals_ibfk_1` FOREIGN KEY (`species`) REFERENCES `zb_species` (`id`);

--
-- Beperkingen voor tabel `zb_food`
--
ALTER TABLE `zb_food`
  ADD CONSTRAINT `zb_food_ibfk_1` FOREIGN KEY (`species`) REFERENCES `zb_species` (`id`);

--
-- Beperkingen voor tabel `zb_species`
--
ALTER TABLE `zb_species`
  ADD CONSTRAINT `zb_species_ibfk_1` FOREIGN KEY (`exhibit`) REFERENCES `zb_exhibits` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
