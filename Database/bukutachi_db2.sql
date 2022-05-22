-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 22, 2022 at 02:47 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bukutachi_db`
--
CREATE DATABASE IF NOT EXISTS `bukutachi_db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `bukutachi_db`;

-- --------------------------------------------------------

--
-- Table structure for table `buku`
--

DROP TABLE IF EXISTS `buku`;
CREATE TABLE `buku` (
  `bu_id` int(11) NOT NULL,
  `bu_title` varchar(100) NOT NULL,
  `bu_synopsis` varchar(2000) NOT NULL,
  `bu_publishedat` int(11) NOT NULL,
  `bu_image` varchar(10000) NOT NULL,
  `bu_status` int(11) NOT NULL DEFAULT 1,
  `bu_pt_id` int(11) NOT NULL,
  `bu_rb_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buku`
--

INSERT INTO `buku` (`bu_id`, `bu_title`, `bu_synopsis`, `bu_publishedat`, `bu_image`, `bu_status`, `bu_pt_id`, `bu_rb_id`) VALUES
(1, 'Harry Potter and the Prisoner of Azkaban', 'Harry Potter 3\r\n\r\nFor Harry Potter, it’s the start of another far-from-ordinary year at Hogwarts when the Knight Bus crashes through the darkness and comes to an abrupt halt in front of him.\r\n\r\nIt turns out that Sirius Black, mass-murderer and follower of Lord Voldemort, has escaped – and they say he is coming after Harry.\r\n\r\nIn his first Divination class, Professor Trelawney sees an omen of death in Harry’s tea leaves.\r\n\r\nAnd perhaps most frightening of all are the Dementors patrolling the school grounds with their soul-sucking kiss – in search of fresh victims', 2014, 'https://covers.openlibrary.org/b/id/1527009-L.jpg', 1, 1, 1),
(2, 'Harry Potter and the Order of the Phoenix', 'Harry Potter 5\r\n\r\nAfter the Dementors’ attack on his cousin Dudley, Harry knows he is about to become Voldemort’s next target.\r\n\r\nAlthough many are denying the Dark Lord’s return, Harry is not alone, and a secret order is gathering at Grimmauld Place to fight against the Dark forces.\r\n\r\nMeanwhile, Voldemort’s savage assaults on Harry’s mind are growing stronger every day.\r\n\r\nHe must allow Professor Snape to teach him to protect himself before he runs out of time.', 2020, 'https://covers.openlibrary.org/b/id/10363325-L.jpg', 1, 2, 1),
(3, 'Harry Potter and the Deathly Hallows', '', 2010, 'https://covers.openlibrary.org/b/id/10082428-L.jpg', 1, 3, 1),
(4, 'Harry Potter and the Goblet of Fire', 'The fourth book in the Harry Potter franchise sees Harry returning for his fourth year at Hogwarts School of Witchcraft and Wizardry, along with his friends, Ron and Hermione . There is an upcoming tournament between the three major schools of magic, with one participant selected from each school by the Goblet of Fire. When Harry s name is drawn, even though he is not eligible and is a fourth player, he must compete in the dangerous contest.', 2010, 'https://covers.openlibrary.org/b/id/12370355-L.jpg', 1, 4, 1),
(5, 'Harry Potter and the Half-Blood Prince', 'Harry Potter 6\r\n\r\nOne summer night, when Dumbledore arrives at Privet Drive to collect Harry Potter, his wand hand is blackened and shriveled, but he will not reveal why.\r\n\r\nRumours and suspicion spread through the wizarding world – it feels as if even Hogwarts itself might be under threat.\r\n\r\nHarry is convinced that Malfoy bears the Dark Mark: could there be a Death Eater amongst them?\r\n\r\nHe will need powerful magic and true friends as, with the help of Dumbledore, he investigates Voldemort’s darkest secrets.', 2010, 'https://covers.openlibrary.org/b/id/10601051-L.jpg', 1, 5, 1),
(6, 'Harry Potter and the Chamber of Secrets', 'Harry Potter 2\r\n\r\nThroughout the summer holidays after his first year at Hogwarts School of Witchcraft and Wizardry, Harry Potter has been receiving sinister warnings from a house-elf called Dobby.\r\n\r\nNow, back at school to start his second year, Harry hears unintelligible whispers echoing through the corridors.\r\n\r\nBefore long the attacks begin: students are found as if turned to stone.\r\n\r\nDobby’s predictions seem to be coming true.', 2020, 'https://covers.openlibrary.org/b/id/12581306-L.jpg', 1, 6, 1),
(7, 'Harry Potter and the Philosopher s Stone', 'Harry Potter 1\r\n\r\nWhen mysterious letters start arriving on his doorstep, Harry Potter has never heard of Hogwarts School of Witchcraft and Wizardry.\r\n\r\nThey are swiftly confiscated by his aunt and uncle.\r\n\r\nThen, on Harry’s eleventh birthday, a strange man bursts in with some important news: Harry Potter is a wizard and has been awarded a place to study at Hogwarts.\r\n\r\nAnd so the first of the Harry Potter adventures is set to begin.', 2014, 'https://covers.openlibrary.org/b/id/9134059-L.jpg', 1, 7, 1),
(8, 'Ultralearning', '', 2019, 'https://covers.openlibrary.org/b/id/10829035-L.jpg', 1, 8, 1),
(9, 'Atomic Habits', '', 2018, 'https://covers.openlibrary.org/b/id/12539702-L.jpg', 1, 9, 1),
(10, 'Why We Want You to Be Rich', '', 2006, 'https://covers.openlibrary.org/b/id/962374-L.jpg', 1, 10, 1),
(11, 'Rich Dad, Poor Dad', 'Argues that a good education and a secure job are not guarantees for financial success, and describes six guidelines for making money work for oneself.', 1990, 'https://covers.openlibrary.org/b/id/8315302-L.jpg', 1, 11, 1),
(12, 'Four Past Midnight', 'Four Past Midnight is a collection of novellas written by Stephen King in 1988 and 1989 and published in August 1990. It is his second book of this type, the first one being Different Seasons. The collection won the Bram Stoker Award in 1990 for Best Collection and was nominated for a Locus Award in 1991.\r\n    \r\nOne Past Midnight: \"The Langoliers\" takes a red-eye flight from L.A. to Boston into a most unfriendly sky. Only eleven passengers survive, but landing in an eerily empty world makes them wish they hadn t. Something s waiting for them, you see....\r\n    \r\nTwo Past Midnight: \"Secret Window, Secret Garden\" enters the suddenly strange life of writer Mort Rainey, recently divorced, depressed, and alone on the shore of Tashmore Lake. Alone, that is, until a figure named John Shooter arrives, pointing an accusing finger.\r\n    \r\nThree Past Midnight: \"The Library Policeman3\" is set in Junction City, Iowa, an unlikely place for evil to be hiding. But for small businessman Sam Peebles, who thinks he may be losing his mind, another enemy is hiding there as well . the truth. If he can find it in time, he might stand a chance.\r\n    \r\nFour Past Midnight: The flat surface of a Polaroid photograph becomes for fifteen-year-old Kevin Delevan an invitation to the supernatural. Old Pop Merrill, Castle Rock s sharpest trader, wants to crash the party for profit, but \"The Sun Dog\" a creature that shouldn t exist at all, is a very dangerous investment.', 2001, 'https://covers.openlibrary.org/b/id/10713177-L.jpg', 1, 12, 1),
(13, 'Flight or Fright', 'Cargo / E. Michael Lewis  . \r\nHorror of the heights / Arthur Conan Doyle  . \r\nNightmare at 20,000 feet / Richard Matheson  . \r\nFlying machine / Ambrose Bierce  . \r\nLucifer! / E.C. Tubb  . \r\nFifth category / Tom Bissell  . \r\nTwo minutes forty-five seconds / Dan Simmons  . \r\nDiablitos / Cody Goodfellow, Cody  . \r\nAir raid / John Varley  . \r\nYou are released / Joe Hill  . \r\nWarbirds / David J. Schow  . \r\nThe flying machine / Ray Bradbury  . \r\nZombies on a plane / Bev Vincent  .  / Roald Dahl  . \r\nMurder in the air / Peter Tremayne  . \r\nThe turbulance expert / Stephen King  . \r\nFalling / James Dickey  . \r\nAfterword: an important message from the flight deck / Bev Vincent.', 2018, 'https://covers.openlibrary.org/b/id/11022187-L.jpg', 1, 13, 1),
(14, 'The Dark Descent', 'pt. 1. The color of evil. The reach / Stephen King  . \r\nEvening primrose / John Collier  . \r\nThe ash-tree / M.R. James  . \r\nThe new mother / Lucy Clifford  . \r\nThere s a long, long trail a-winding / Russell Kirk  . \r\nThe call of Cthulhu / H.P. Lovecraft  . \r\nThe summer people / Shirley Jackson  . \r\nThe whimper of whipped dogs / Harlan Ellison  . \r\n[Young Goodman Brown](https://openlibrary.org/works/OL455569W/Young_Goodman_Brown) / Nathaniel Hawthorne  . \r\nMr. Justice Harbottle  . \r\nJ. Sheridan Le Fanu  . \r\nThe crowd / Ray Bradbury  . \r\nThe autopsy / Michael Shea  . \r\nJohn Charrington s wedding / E. Nesbit  . \r\nSticks / Karl Edward Wagner  . \r\nLarger than oneself / Robert Aickman  . \r\nBelsen Express / Fritz Leiber  . \r\nYours truly, Jack the Ripper / Robert Bloch  . \r\nIf Damon comes / Charles L. Grant  . \r\nVandy, Vandy / Manly Wade Wellman  . \r\npt. 2. The Medusa in the shield. The swords / Robert Aickman  . \r\nThe roaches / Thomas M. Disch  . \r\nBright segment / Theodore Sturgeon  . \r\nDread / Clive Barker  . \r\nThe fall of the house of Usher / Edgar Allan Poe  . \r\nThe monkey / Stephen King  . \r\nWithin the walls of Tyre / Michael Bishop  . \r\nThe rats in the walls / H.P. Lovecraft  . \r\nSchalken the painter / J. Sheridan Le Fanu  . \r\nThe yellow wallpaper / Charlotte Perkins Gilman  . \r\nA rose for Emily / William Faulkner  . \r\nHow love came to Professor Guildea / Robert Hichens  . \r\nBorn of man and woman / Richard Matheson  . \r\nMy dear Emily / Joanna Russ  . \r\nYou can go now / Dennis Etchison  . \r\nThe rocking-horse winner / D.H. Lawrence  . \r\nThree days / Tanith Lee  . \r\nGood country people / Flannery O Connor  . \r\nMackintosh Willy / Ramsey Campbell  . \r\nThe jolly corner / Henry James  . \r\npt. 3. A fabulous formless darkness. Smoke ghost / Fritz Leiber  . \r\nSeven American nights / Gene Wolfe  . \r\nThe signal-man / Charles Dickens  . \r\n[Crouch End](https://openlibrary.org/works/OL19650699W/Crouch_End) / Stephen King  . \r\nNight-side / Joyce Carol Oates  . \r\nSeaton s aunt / Walt', 1987, 'https://covers.openlibrary.org/b/id/4129432-L.jpg', 1, 14, 1),
(15, 'The Outsiders', 'According to Ponyboy, there are two kinds of people in the world: greasers and socs. A soc (short for \"social\") has money, can get away with just about anything, and has an attitude longer than a limousine. A greaser, on the other hand, always lives on the outside and needs to watch his back. Ponyboy is a greaser, and he s always been proud of it, even willing to rumble against a gang of socs for the sake of his fellow greasers . until one terrible night when his friend Johnny kills a soc. The murder gets under Ponyboy s skin, causing his world to crumble and teaching him that pain feels the same whether a soc or a greaser.', 1967, 'https://covers.openlibrary.org/b/id/5418251,5306334-L.jpg', 1, 15, 1),
(16, 'The Zombies Greatest Hits (Sheet Music for piano/vocal/guitar)', '', 2000, 'https://covers.openlibrary.org/b/id/5084835-L.jpg', 1, 16, 1),
(17, 'Black House', 'Preceded by: The Talisman\r\n\r\nBlack House is a horror novel by American writers Stephen King and Peter Straub. Published in 2001, it is the sequel to The Talisman. This is one of King s numerous novels that tie in with the Dark Tower series. Black House was nominated to the Bram Stoker Award for Best Novel.\r\n\r\nThe novel is set in Straub s homeland of Wisconsin, rather than in King s frequently used backdrop of Maine. The town of \"French Landing\" is a fictionalized version of the town of Trempealeau, Wisconsin. Also, \"Centralia\" is named after the nearby small town of Centerville, Wisconsin, located at the intersection of Hwy 93 and Hwy 35.', 2001, 'https://covers.openlibrary.org/b/id/12018533-L.jpg', 1, 17, 1),
(18, 'Charlie and the Great Glass Elevator', 'Taking up where Charlie and the Chocolate Factory leaves off, Charlie, his family, and Mr. Wonka find themselves launched into space in the great glass elevator.', 1991, 'https://covers.openlibrary.org/b/id/8918617-L.jpg', 1, 18, 1),
(19, 'The Magic Ladder to Success', '', 2018, 'https://covers.openlibrary.org/b/id/11503304-L.jpg', 1, 19, 1),
(20, 'Success Secrets of the Great Masters', '', 2019, 'https://covers.openlibrary.org/b/id/8801308-L.jpg', 1, 20, 2),
(21, 'Grow Rich With Peace of Mind', 'In this exciting book, the renowned author of THINK AND GROW RICH, Napoleon Hill, reveals his latest discoveries about getting what you want . and making the most of it. Here, in simple, readable language, are the foolproof techniques for achieving the power to earn money and to enjoy genuine inner peace. You wil learn: how to succeed in life, succeed in being yourself; how to develop your own healthy ego; how to win the job you want . and keep going upward; how to turn every challenge into a new success, and more.', 1967, 'https://covers.openlibrary.org/b/id/11639668-L.jpg', 1, 21, 2),
(22, 'Habits Worth Tracking', '', 2019, 'https://covers.openlibrary.org/b/id/11579821-L.jpg', 1, 22, 2),
(23, 'Think and grow rich', 'THE WORKBOOK UNLOCKS THE SECRETS HIDDEN BETWEEN THE LINES \r\nNapoleon Hill was quoted as saying, “You can’t really get Think and Grow Rich by reading it just once. There is just as much written between the lines as there is written in the lines themselves.” Now Think and Grow Rich: The 21st-Century Edition Workbook will show you how to get the most out of Hill’s classic success book the very first time you read it. This workbook is designed to guide you through Think and Grow Rich and explain it so clearly that when you come to the last page you will know the book better than most devoted students who have read it many times over. \r\nKEYED TO THE FORMAT OF THE BOOK \r\nFollowing the format of Think and Grow Rich, this work- book breaks down each of Napoleon Hill’s principles, fills in the background, takes you step-by-step through his arguments, and explains how and why Hill arrived at his theories. In addition to a detailed overview of Think and Grow Rich, this workbook also features: chapter outlines, updated examples, new research breakdowns and summaries of all key concepts action guides and self-tests \r\nYOUR OWN PRIVATE TUTOR \r\nIt’s like having your own personal instructor leading you through the book, explaining how to read each chapter so that you see clearly, learn quickly, and understand completely. The result is an extremely practical program created specifically to make Think and Grow Rich the most important book you have ever read.', 1964, 'https://covers.openlibrary.org/b/id/10528858-L.jpg', 1, 23, 2),
(24, 'Law of Success - Law of Attraction', '', 2017, 'https://covers.openlibrary.org/b/id/11255332-L.jpg', 1, 24, 2),
(25, 'How to Own Your Own Mind', '', 2017, 'https://covers.openlibrary.org/b/id/8846060-L.jpg', 1, 25, 2),
(26, 'How to win friends and influence people, how to stop worrying and start living, the quick and easy w', '', 2008, 'https://covers.openlibrary.org/b/id/12675732-L.jpg', 1, 26, 2),
(27, 'How to Win Friends and Influence People in the Digital Age', '', 2012, 'https://covers.openlibrary.org/b/id/9095869-L.jpg', 1, 27, 2),
(28, 'The quick & easy way to effective speaking', '', 1962, 'https://covers.openlibrary.org/b/id/10575358-L.jpg', 1, 28, 2),
(29, 'The Little Recognized Secret of Success', '', 2017, 'https://covers.openlibrary.org/b/id/8878713-L.jpg', 1, 29, 2),
(30, 'Sales Advantage', '', 2003, 'https://covers.openlibrary.org/b/id/1384595-L.jpg', 1, 30, 2),
(31, 'The Art of public speaking', '', 1983, 'https://covers.openlibrary.org/b/id/6379791-L.jpg', 1, 31, 2),
(32, 'New Art of Public Speaking', '', 2006, 'https://covers.openlibrary.org/b/id/2130205-L.jpg', 1, 32, 2),
(33, 'Diary of a Wimpy Kid - Dog Days', '', 2007, 'https://covers.openlibrary.org/b/id/6309487-L.jpg', 1, 33, 2),
(34, 'Diary of a wimpy kid the gateway', 'This book is funny and a good read for younger children such as 2-4 grade.', 2019, 'https://covers.openlibrary.org/b/id/10641238-L.jpg', 1, 34, 2),
(35, 'Pioneers of Modern Design', '', 1960, 'https://covers.openlibrary.org/b/id/7023148-L.jpg', 1, 35, 2),
(36, 'West-Riding election', '', 1841, 'https://covers.openlibrary.org/b/id/6007074-L.jpg', 1, 36, 2),
(37, 'Affordable dreams', '', 1991, 'https://covers.openlibrary.org/b/id/4835770-L.jpg', 1, 37, 2),
(38, 'The future of architecture', '', 1981, 'https://covers.openlibrary.org/b/id/10429429-L.jpg', 1, 38, 2),
(39, 'Jolly Christmas Songs', '', 2004, 'https://covers.openlibrary.org/b/id/1416286-L.jpg', 1, 39, 2),
(40, 'Harvard Rules', 'It is the richest, most influential, most powerful university in the world, but at the beginning of 2001, Harvard was in crisis. Students complained that a Harvard education had grown mediocre. Professors charged that the university cared more about money than about learning. And everyone worried that Harvard s outgoing president, Neil Rudenstine, epitomized an unhappy trend: the university president as full-time fund-raiser. Harvard may have possessed a $19 billion endowment, but had the university lost its soul?The members of the Harvard Corporation, the ultra-secretive governing board established more than three centuries ago, knew that they had to act. And so they made a bold pick for Harvard s twenty-seventh president: former Treasury Secretary and intellectual prodigy economist Lawrence Summers.Although famously brilliant, Summers was a high-stakes gamble. In the 1990s he had crafted American policies to stabilize the global economy, quietly becoming one of the world s most powerful men. But while many admired Summers, his critics called him elitist, imperialist, and arrogant beyond measure.Today Larry Summers sits atop a university in a state of upheaval, unsure of what it stands for and where it is going. His allies believe that Harvard needs shaking up and appreciate Summer s blunt language and unabashed displays of power. His foes accuse the new president of tearing apart a venerable institution simply to remake it in his own image. At stake is not just the future of Harvard University, but the way in which Harvard students see the world  .  and the manner in which they will lead it.Written despite the university s official opposition, Harvard Rules uncovers what really goes on behind Harvard s storied walls  .  the politics, sex, ambition, infighting, and intrigue that run rampant within the world s most important university.', 2005, 'https://covers.openlibrary.org/b/id/6404750-L.jpg', 1, 40, 2),
(41, 'Premier Piano Course Lesson Book, Bk 2B', '', 2006, 'https://covers.openlibrary.org/b/id/1376278-L.jpg', 1, 41, 2),
(42, 'Premier Piano Course Lesson Book, Bk 1B', '', 2005, 'https://covers.openlibrary.org/b/id/2569645-L.jpg', 1, 16, 2),
(43, 'The Nutcracker Suite (Nutcracker Suite)', '', 1993, 'https://covers.openlibrary.org/b/id/1503489-L.jpg', 1, 42, 2),
(44, 'Elementary photographic chemistry', '', 1924, 'https://covers.openlibrary.org/b/id/11508846-L.jpg', 1, 43, 3),
(45, 'Kodak Guide to 35mm Photography', '', 1989, 'https://covers.openlibrary.org/b/id/676337-L.jpg', 1, 44, 3),
(46, 'How to take good pictures', '', 1995, 'https://covers.openlibrary.org/b/id/12158904-L.jpg', 1, 40, 3),
(47, 'Using Filters', '', 1995, 'https://covers.openlibrary.org/b/id/676324-L.jpg', 1, 45, 3),
(48, 'Photoshop 6 Killer Tips', '', 2001, 'https://covers.openlibrary.org/b/id/461831-L.jpg', 1, 46, 3),
(49, 'The Photoshop Channels Book', '', 2006, 'https://covers.openlibrary.org/b/id/193372-L.jpg', 1, 47, 3),
(50, 'Mac OS X', '', 2001, 'https://covers.openlibrary.org/b/id/7898615-L.jpg', 1, 48, 3),
(51, 'IPod Book', '', 2007, 'https://covers.openlibrary.org/b/id/193760-L.jpg', 1, 49, 3),
(52, 'Masterclass in Photography', '', 2003, 'https://covers.openlibrary.org/b/id/918356-L.jpg', 1, 50, 3),
(53, '100 ways to take better photographs', '', 2003, 'https://covers.openlibrary.org/b/id/454752-L.jpg', 1, 51, 3),
(54, 'Creative Digital Photography', '', 2005, 'https://covers.openlibrary.org/b/id/895204-L.jpg', 1, 52, 3),
(55, 'The encyclopedia of photography', '', 1983, 'https://covers.openlibrary.org/b/id/10393150-L.jpg', 1, 53, 3),
(56, 'Canon EOS 60D for dummies', 'Expand your creativity, and learn to use all you 60D s professional features. You ll get a guided tour of every control, learn to use the automatic modes, and download and share your images.', 2011, 'https://covers.openlibrary.org/b/id/11918678-L.jpg', 1, 54, 3),
(57, 'Nikon D600 for Dummies', '', 2012, 'https://covers.openlibrary.org/b/id/7859618-L.jpg', 1, 54, 3),
(58, 'Nikon D5200 for Dummies', '', 2013, 'https://covers.openlibrary.org/b/id/7859616-L.jpg', 1, 54, 3),
(59, 'Adobe PhotoDeluxe for dummies', '', 1998, 'https://covers.openlibrary.org/b/id/520280-L.jpg', 1, 55, 3),
(60, 'King Richard III', '\"containing his treacherous plots against his brother Clarence, the pittiefull murther of his innocent nephewes, his tyrannicall usurpation, with the whole course of his detested life and most deserved death\"\r\n(Subtitle of the 1597 edition.)', 2018, 'https://covers.openlibrary.org/b/id/7477202-L.jpg', 1, 56, 3),
(61, 'The Lightening Thief Journal', '', 2006, 'https://covers.openlibrary.org/b/id/12518853-L.jpg', 1, 57, 3),
(62, 'Percy Jackson s Greek heroes', '\"Who cut off Medusa s head? Who was raised by a she-bear? Who tamed Pegasus? It takes a demigod to know, and Percy Jackson can fill you in on the all the daring deeds of Perseus, Atalanta, Bellerophon, and the rest of the major Greek heroes. Told in the funny, irreverent style readers have come to expect from Percy  .  Provided by publisher.', 2018, 'https://covers.openlibrary.org/b/id/10250553-L.jpg', 1, 58, 3),
(63, 'The Heroes of Olympus', '', 2015, 'https://covers.openlibrary.org/b/id/12108150-L.jpg', 1, 59, 3),
(64, 'The Titan', 'Frank Algernon Cowperwood, the central character of Theodore Dreiser s previous work \"The Financier,\" is now out of the Eastern District Penitentiary of Philadelphia. He still has his mistress and his fortune, plans to divorce his wife, and leaves for Chicago to scout its possibilities for a future home. He has letters of introduction to the most influential people . a bank president named Mr. Addison, for a start. Cowperwood is presented to others . lawyers, businessmen, and judges. At this beginning not one of them knew he had been incarcerated, and he wondered if that knowledge would affect their attitude towards him. He finally confesses his recent history to Addison and decides to establish his new company in Chicago. He carefully and thoroughly scrutinizes the conditions for establishing a wealth that would be envied by powerful men and selfish women. \"The magnetizing power of fame is great.\" As Cowperwood climbs the glorified mountain and sets out to ultimately conquer this new world, his past foibles overcome him again . his desire for beautiful women, his acquisition of unbelievable wealth, his need to be accepted and understood and revered. His genius for social and financial manipulations fails him in politics. The ending is a philosophical overview of what has happened and what can happen to a man with a restless heart.', 2007, 'https://covers.openlibrary.org/b/id/4849894,4530130-L.jpg', 1, 60, 3),
(65, 'The plumed serpent', '', 1955, 'https://covers.openlibrary.org/b/id/9990459-L.jpg', 1, 61, 3),
(66, 'The Elves of Cintra', '', 2008, 'https://covers.openlibrary.org/b/id/11710935-L.jpg', 1, 62, 3),
(67, 'Black Unicorn', 'Nobody knew where it had come from, or what it wanted. Not even Jaive, the sorceress, could fathom the mystery of the fabled beast. But Tanaquil, Jaive s completely unmagical daughter, understood it at once. She knew why the unicorn was there: It had come for her. It needed her. Tanaquil was amazed because she was the girl with no talent for magic. She could only fiddle with broken bits of machinery and make them work again. What could she do for a unicorn?', 1994, 'https://covers.openlibrary.org/b/id/10528178-L.jpg', 1, 63, 3),
(68, 'Sword of Bedwyr', '', 2019, 'https://covers.openlibrary.org/b/id/8087088-L.jpg', 1, 64, 4),
(69, 'The Color of Dragons', '', 2021, 'https://covers.openlibrary.org/b/id/12502098-L.jpg', 1, 65, 4),
(70, 'Out of the Silent Planet', 'The first book in Lewis s Space Trilogy, *Out of the Silent Planet* tells the story of Dr. Elwin Ransom, a philologist who likes to explore the English countryside on foot.  Seeking out a place to stay the night, he ends up at the estate of a colleague who is away in London.  However, the house is not empty.  Ransom stumbles upon the plot of a megalomaniacal scientist and his collaborator, who just happens to be an old schoolmate of Ransom s.  Drugged, kidnapped, and wisked away in the scientists rocket to the planet Malacandra where he is to serve as a human sacrifice, Dr. Ransom escapes into the strange Malacandran wilderness pursued by his kidnappers and abandoning his hopes of returning to Earth.\r\n\r\nRansom discovers that the inhabitants of Malacandra are not what his kidnappers believed them to be.  In his adventures in the often strangely beautiful, sometimes dangerous, and sometimes surprisingly familiar Malacandra and its inhabitants, Ransom uncovers information about the larger universe and Earth s place that suggest he has as much to discover about his home planet as he does about the alien Malacandra.', 1945, 'https://covers.openlibrary.org/b/id/9321665-L.jpg', 1, 66, 4),
(71, 'The Horse and His Boy', 'A boy and a talking horse share an adventurous and dangerous journey to Narnia to warn of invading barbarians.', 2020, 'https://covers.openlibrary.org/b/id/12212562-L.jpg', 1, 67, 4),
(72, 'The Four Loves', 'In his classic book The Four Loves, Lewis describes the four basic kinds of human love-affection, friendship, erotic love, and the love of God. Since this is the only commercial recording of C. S. Lewis that is available today, fans of his writing will desire to add this impressive recording to their collection. While Lewis s writings have impacted more evangelical Christians than perhaps any other writer, this audio product of the author s reading of this classic book will undoubtedly expand the theological understanding of the nature of love to a much wider audience. He explores the love between parents and children, the love of friends, the love of men and women for each other, and the love of God that may enrich all love. He also goes in-depth into questions of sex, possessiveness, jealousy, pride, false sentimentality, manners in loving, and the need for more laughter between lovers. Lewis s wise and candid reflections on the virtues and dangers of love draw on sources from Jane Austen to Saint Augustine. This recording features a new audio introduction and commentary by Chuck Colson. The CD will also include a study guide . perfect for individual or group use. - Publisher.', 1960, 'https://covers.openlibrary.org/b/id/9321672-L.jpg', 1, 68, 4),
(73, 'The Poison Belt', 'Being an account of another adventure of Prof. George E. Challenger, Lord John Roxton, Prof. Summerlee and Mr E. D. M\r\nalone, the discoverers of \"The Lost World\".', 1913, 'https://covers.openlibrary.org/b/id/10827496-L.jpg', 1, 69, 4),
(74, 'The Hound of the Baskervilles', '***In this classic mystery set in 19th-century England, Sherlock Holmes and Dr. Watson are faced with discovering the truth behind the curse on the wealthy Baskerville family.*** \r\n\r\n**We owe The Hound of the Baskervilles (1902) to Arthur Conan Doyle s good friend Fletcher \"Bobbles\" Robinson,** who took him to visit some scary English moors and prehistoric ruins, and told him marvelous local legends about escaped prisoners and a 17th-century aristocrat who fell afoul of the family dog.\r\n\r\n***Doyle transmogrified the legend: generations ago,*** a hound of hell tore out the throat of devilish Hugo Baskerville on the moonlit moor. Poor, accursed Baskerville Hall now has another mysterious death: that of Sir Charles Baskerville. Could the culprit somehow be mixed up with secretive servant Barrymore, history-obsessed Dr. Frankland, butterfly-chasing Stapleton, or Selden, the Notting Hill murderer at large? Someone s been signaling with candles from the mansion s windows. Nor can supernatural forces be ruled out. **Can Dr. Watson . left alone by Sherlock Holmes to sleuth in fear for much of the novel . save the next Baskerville, Sir Henry, from the hound s fangs?**\r\n\r\n**Many Holmes fans prefer Doyle s complete short stories, but their clockwork logic doesn t match the author s boast about this novel: *it s \"a real Creeper!\"*** What distinguishes this particular Hound is its fulfillment of Doyle s great debt to Edgar Allan Poe . it s full of ancient woe, low moans, a Grimpen Mire that sucks ponies to Dostoyevskian deaths, and locals digging up Neolithic skulls without next-of-kins  consent. ***\"The longer one stays here the more does the spirit of the moor sink into one s soul,\" Watson realizes.*** \"Rank reeds and lush, slimy water-plants sent an odour of decay ... while a false step plunged us more than once thigh-deep into the dark, quivering mire, which shook for yards in soft undulations around our feet ... **it was as if some malignant hand was tugging us down into th', 2007, 'https://covers.openlibrary.org/b/id/10232843-L.jpg', 1, 70, 4),
(75, 'The Valley of Fear', 'Even Sherlock Holmes, well-accustomed to the bizarre, finds the elements of this case unusual; the scene of the crime, a moated English country house; the wapon, a very American sawed-off shotgun; the bereaved, strangely dry-eyed; and the solution, backward in time and deep in a VALLEY OF FEAR...', 1980, 'https://covers.openlibrary.org/b/id/10862830-L.jpg', 1, 71, 4),
(76, 'The Lost World', 'Journalist Ed Malone is looking for an adventure, and that s exactly what he finds when he meets the eccentric Professor Challenger - an adventure that leads Malone and his three companions deep into the Amazon jungle, to a lost world where dinosaurs roam free.', 1991, 'https://covers.openlibrary.org/b/id/8785066-L.jpg', 1, 72, 4),
(77, 'The Return of Sherlock Holmes', 'The Return of Sherlock Holmes is a 1905 collection of 13 Sherlock Holmes stories, originally published in 1903–1904, by Arthur Conan Doyle. The stories were published in the Strand Magazine in Britain and Collier s in the United States.\r\n\r\nContains:\r\n[Adventure of the Empty House\r\n[Adventure of the Norwood Builder]\r\n[Adventure of the Dancing Men]\r\n[Adventure of the Solitary Cyclist]\r\n[Adventure of the Priory School]\r\nBlack Peter\r\n[Adventure of Charles Augustus Milverton]\r\n[Six Napoleons]\r\n[Adventure of the Three Students]\r\n[Adventure of the Golden Pince-Nez]\r\n[Adventure of the Missing Three-Quarter]\r\n[Adventure of the Abbey Grange]\r\n[Second Stain]', 2004, 'https://covers.openlibrary.org/b/id/12506283-L.jpg', 1, 73, 4),
(78, 'The Sign of Four', 'The Sign of the Four (1890), also called The Sign of Four, is the second novel featuring Sherlock Holmes written by Sir Arthur Conan Doyle.', 2004, 'https://covers.openlibrary.org/b/id/9660568-L.jpg', 1, 74, 4),
(79, 'A Study in Scarlet', 'A Study in Scarlet (STUD) is the first Sherlock Holmes novel written by Arthur Conan Doyle first published in the Beeton s Christmas Annual in 1887. This is the 1st Sherlock Holmes story.', 2004, 'https://covers.openlibrary.org/b/id/12056599-L.jpg', 1, 75, 4),
(80, 'The White Company', 'From the book:The great bell of Beaulieu was ringing. Far away through the forest might be heard its musical clangor and swell. Peat-cutters on Blackdown and fishers upon the Exe heard the distant throbbing rising and falling upon the sultry summer air. It was a common sound in those parts - as common as the chatter of the jays and the booming of the bittern. Yet the fishers and the peasants raised their heads and looked questions at each other, for the angelus had already gone and vespers was still far off. Why should the great bell of Beaulieu toll when the shadows were neither short nor long?   All round the Abbey the monks were trooping in. Under the long green-paved avenues of gnarled oaks and of lichened beeches the white-robed brothers gathered to the sound. From the vine-yard and the vine-press, from the bouvary or ox-farm, from the marl-pits and salterns, even from the distant iron-works of Sowley and the outlying grange of St.Leonard s, they had all turned their steps home-wards', 1909, 'https://covers.openlibrary.org/b/id/8244602-L.jpg', 1, 76, 4),
(81, 'Through the Magic Door', '', 1907, 'https://covers.openlibrary.org/b/id/9987692,5791477-L.jpg', 1, 77, 4),
(82, 'Five Go Off in a Caravan', 'A caravan holiday for the Famous Five is bound to be an adventure! And when they stumble across a circus troupe, the gang are thrilled. But some of the circus people have more sinister plans than just clowning around.', 2003, 'https://covers.openlibrary.org/b/id/2396780-L.jpg', 1, 12, 4),
(83, 'Five go down to the sea', 'Who would deliberately lure somebody on to treacherous rocks on the Cornish coast? Somebody is flashing lights from the old tower on stormy nights  .  and the Famous Five sense danger. But can they solve this mystery safely?', 1953, 'https://covers.openlibrary.org/b/id/2396785-L.jpg', 1, 12, 4),
(84, 'Five on a Treasure Island', 'Julian, Dick, Anne, George and Timmy the dog find excitement and adventure wherever they go in Enid Blyton s most popular series. In their first adventure, the Famous Five find a shipwreck off Kirrin Island. But where is the treasure? The Famous Five are on the trail, looking for clues, but they re not alone. Someone else has got the same idea! Time is running out for the Famous Five  .  who will follow the clues and get to the treasure first?', 1942, 'https://covers.openlibrary.org/b/id/10481738-L.jpg', 1, 78, 4),
(85, 'Death on the Nile', 'The tranquillity of a cruise along the Nile was shattered by the discovery that Linnet Ridgeway ( Linnet Doyle) had been shot through the head. She was young, stylish, rich and beautiful. A girl who had everything... until she lost her life.\r\n\r\nHercule Poirot recalled an earlier outburst by a fellow passenger:  I d like to put my dear little pistol against her head and just press the trigger.  Yet in this exotic setting nothing was ever quite what it seemed...', 2004, 'https://covers.openlibrary.org/b/id/10252221-L.jpg', 1, 79, 4),
(86, 'The Murder of Roger Ackroyd', 'Belgian Inspector Hercule Poirot has retired to the countryside in the small English village of King s Abbot. Dr. Sheppard, observing his new neighbor, is sure that he must be a former hairdresser. But the brutal murder of a local squire reveals the truth: the peculiar little man is actually a detective par excellence. The Murder of the wealthy industrialist Roger Ackroyd begins the night before with the suicide of Mrs. Ferrars, a wealthy widow. Her death is believed to be an accident, until Roger Ackroyd is stabbed to death in his locked study. There are rumors she poisoned her first husband, rumors that she was being blackmailed, rumors that her secret lover was Roger Ackroyd, a man who knew too much, but no one is sure.\r\n \r\nThere s no shortage of suspects, all the members of the household stand to gain from his death, from Roger s neurotic sister-in-law who has accumulated personal debts, to a parlormaid with an uncertain history who resigned her post the afternoon of the murder. But the police focus on Ralph Paton, Ackroyd s stepson and heir, and the person with the most to gain from Roger s death. When sleuth Hercule Poirot, who is living quietly in King s Abbot, agrees to investigate, the case takes a completely different turn. Poirot exonerates all of the original suspects, and lays out a completely reasoned case that the clever and devious murderer is someone who had not come under suspicion at all - someone whose motive has nothing to do with money.', 2004, 'https://covers.openlibrary.org/b/id/12705608-L.jpg', 1, 80, 4),
(87, 'The Hollow', 'E-book exclusive extras:1) Christie biographer Charles Osborne s essay on The Hollow;2) \"The Poirots\": the complete guide to all the cases of the great Belgian detective.', 2011, 'https://covers.openlibrary.org/b/id/10139299-L.jpg', 1, 81, 4),
(88, 'Murder on the Orient Express', '***While en route from Syria to Paris, in the middle of a freezing winter s night, the Orient Express is stopped dead in its tracks by a snowdrift.*** Passengers awake to find the train still stranded and to discover that a wealthy American has been brutally stabbed to death in his private compartment. Incredibly, that compartment is locked from the inside. With no escape into the wintery landscape the killer must still be on board. ***Fortunately, the brilliant Belgian inspector Hercule Poirot is also on board, having booked the last available berth.***\r\n\r\n***Murder on the Orient Express is one of Agatha Christie’s most famous novels***, owing no doubt to a combination of its romantic setting and the ingeniousness of its plot; its non-exploitative reference to the sensational kidnapping and murder of the infant son of Charles and Anne Morrow Lindbergh only two years prior; and a popular ***1974 film adaptation, starring Albert Finney as Poirot - one of the few cinematic versions of a Christie work that met with the approval, however mild, of the author herself.***', 1977, 'https://covers.openlibrary.org/b/id/10202515-L.jpg', 1, 82, 4),
(89, 'The A.B.C. Murders', '***There s a serial killer on the loose, bent on working his way through the alphabet. And***  as a macabre calling card he leaves beside each victim s corpe the ABC Railway Guide open at the name of the town where the murder has taken place. Having begun with Andover, Bexhill and then Churston, ***there seems little chance of the murderer being caught - until he makes the crucial and vain mistake of challenging Hercule Poirot*** to frustrate his plans.** . goodreads**\r\n\r\n***The A.B.C. Murders is a work of detective fiction by British writer Agatha Christie, featuring her characters Hercule Poirot, Arthur Hastings and Chief Inspector Japp,*** as they contend with a series of killings by a mysterious murderer known only as \"A.B.C.\". The book was **first published in the UK by the Collins Crime Club** on 6 January 1936, sold for seven shillings and sixpence (7/6) while a US edition, **published by Dodd, Mead and Company on 14 February of the same year**, was priced $2.00. \r\n\r\n**The form of the novel is unusual, combining first-person narrative and third-person narrative.** This approach was previously used by Agatha Christie in The Man in the Brown Suit. In The A.B.C. Murders the third-person narrative is supposedly reconstructed by the first-person narrator of the story, Arthur Hastings.\r\n\r\n**The novel was well received in the UK and the US when it was published.** One reviewer said it was \"a baffler of the first water,\" while another remarked on Christie s ingenuity in the plot] **A reviewer in 1990 said it was \"a classic, still fresh story, beautifully worked out.\"* . Wikipedia***', 2011, 'https://covers.openlibrary.org/b/id/11433680-L.jpg', 1, 83, 4),
(90, 'After the Funeral', 'When Cora is savagely murdered with a hatchet, the extraordinary remark she made the previous day at her brother Richard s funeral suddenly takes on a chilling significance. At the reading of Richard s will, Cora was clearly heard to say:  It s been hushed up very nicely, hasn t itBut he was murdered, wasn t he?  In desperation, the family solicitor turns to Hercule Poirot to unravel the mystery.', 2014, 'https://covers.openlibrary.org/b/id/12047922-L.jpg', 1, 84, 4),
(91, 'The Secret of Chimneys', 'A bit of adventure and quick cash is all that good-natured drifter Anthony Cade is looking for when he accepts a messenger job from an old friend. It sounds so simple: deliver the provocative memoirs of a recently deceased European count to a London publisher. Little did Anthony suspect that a simple errand to deliver the manuscript on behalf of his friend would drop him right in the middle of an international conspiracy, and he begins to realize that it has placed him in serious danger. Why were Count Stylptich s memoirs so important? And what was \"King Victor\" really after? The parcel holds ore than scandalous royal secrets - because it contains a stash of letters that suggest blackmail. Someone would stop at nothing to prevent the monarchy being restored in faraway Herzoslovakia.\r\n\r\nWherever ravishing Virginia Revel went, death seemed sure to follow. First her husband died. The next to perish was a foreign prince whose ruthless power was matched by his scandalous passions. Then a bungling blackmailer followed them into the grave. Murder, blackmail, stolen letters, and a fabulous missing jewel: all under the not always co-operative eyes of Scotland Yard and the Surete. All threads lead to Chimneys, one of England s historic country house estates, where a master murderer mingled with the aristocratic guests. Virginia could turn to only one person to prove her innocence and end her nightmare, and she could only pray that she had not put her life into the hands of the man who was out to take it....\r\n\r\nThis novel was published in 1925 by Bodley Head in London, and by Dodd, Mead & Co. in New York. The Times Literary Supplement described it as \"a thick fog of mystery, cross purposes, and romance, which leads up to a most unexpected and highly satisfactory ending\".Chimneys was adapted by Christie as a stage play but was not performed until 2003, in Canada. It was filmed with the addition of Julia McKenzie as Miss Marple by ITV in 2009.', 1977, 'https://covers.openlibrary.org/b/id/10662928-L.jpg', 1, 85, 4),
(92, 'Poirot Investigates', 'First there was the mystery of the film star and the diamond… then came the ‘suicide’ that was murder… the mystery of the absurdly chaep flat… a suspicious death in a locked gun-room… a million dollar bond robbery… the curse of a pharoah’s tomb… a jewel robbery by the sea… the abduction of a Prime Minister… the disappearance of a banker… a phone call from a dying man… and, finally, the mystery of the missing will.  What links these fascinating cases? Only the brilliant deductive powers of Hercule Poirot!', 2007, 'https://covers.openlibrary.org/b/id/3115850-L.jpg', 1, 86, 4),
(93, 'Taken By Her Mates', '', 2021, 'https://covers.openlibrary.org/b/id/12602064-L.jpg', 1, 87, 4),
(94, 'His Virgin Mate', '', 2019, 'https://covers.openlibrary.org/b/id/10377219-L.jpg', 1, 88, 4),
(95, 'Rogue and the Rebel', '', 2008, 'https://covers.openlibrary.org/b/id/10475286-L.jpg', 1, 89, 4),
(96, 'Beauty and the Beast (Beauty & the Beast)', '', 1983, 'https://covers.openlibrary.org/b/id/8165857-L.jpg', 1, 90, 4),
(97, 'Fifty Shades Darker', 'Daunted by the singular tastes and dark secrets of the beautiful, tormented young entrepreneur Christian Grey, Anastasia Steele has broken off their relationship to start a new career with a Seattle publishing house.\r\nBut, desire for Christian still dominates her every waking thought, and when he proposes a new arrangement, Ana cannot resist. They rekindle their searing sensual affair, and Ana learns more about the barrowing past of her damaged, driven, and demanding Fifty Shades.\r\nWhile Christian wrestles with his inner demons, Ana, must confront the anger and envy of the woman who came before her, and make the most important decision of her life.', 2011, 'https://covers.openlibrary.org/b/id/10382969-L.jpg', 1, 91, 4),
(98, 'Fifty Shades of Grey', 'hen literature student Anastasia Steele goes to interview young entrepreneur Christian Grey, she encounters a man who is beautiful, brilliant, and intimidating. The unworldly, innocent Ana is startled to realize she wants this man and, despite his enigmatic reserve, finds she is desperate to get close to him. Unable to resist Ana’s quiet beauty, wit, and independent spirit, Grey admits he wants her, too—but on his own terms.\r\n \r\nShocked yet thrilled by Grey’s singular erotic tastes, Ana hesitates. For all the trappings of success—his multinational businesses, his vast wealth, his loving family—Grey is a man tormented by demons and consumed by the need to control. When the couple embarks on a daring, passionately physical affair, Ana discovers Christian Grey’s secrets and explores her own dark desires.\r\n\r\nErotic, amusing, and deeply moving, the Fifty Shades Trilogy is a tale that will obsess you, possess you, and stay with you forever.\r\n\r\nThis book is intended for mature audiences.', 2012, 'https://covers.openlibrary.org/b/id/12648172-L.jpg', 1, 92, 4),
(99, 'Fifty Shades Freed', '', 2012, 'https://covers.openlibrary.org/b/id/10908848-L.jpg', 1, 93, 4),
(100, 'Sex and Vanity', '', 2020, 'https://covers.openlibrary.org/b/id/10526865-L.jpg', 1, 94, 5),
(101, 'China Rich Girlfriend', '', 2020, 'https://covers.openlibrary.org/b/id/10900801-L.jpg', 1, 95, 5),
(102, 'Crazy Rich Asians', '(Description comes from the 2013 Anchor Books edition)\r\n\r\nWhen New Yorker Rachel Chu agrees on a summer in Singapore to visit her boyfriend s \"traditional\" Chinese family, she expects the visit to be relaxing, if a little dull. She has no idea....\r\n\r\nNick s childhood home is a palace. He grew up riding in more private planes than cars. He and Rachel will be attending the wedding of the year. Oh, and Nick just happens to be one of Asia s more eligible bachelors . and his formidable mother isn t so sure Rachel is the right one for him.', 2014, 'https://covers.openlibrary.org/b/id/10871887-L.jpg', 1, 96, 5),
(103, 'Rich people problems', '\"[A] novel of a family riven by fortune, an ex-wife driven psychotic with jealousy, a battle royal fought through couture gown sabotage, and the heir to one of Asia s greatest fortunes locked out of his inheritance\"  .  provided by publisher.', 2017, 'https://covers.openlibrary.org/b/id/8876376-L.jpg', 1, 91, 5),
(104, 'The Fault in Our Stars', 'Despite the tumor-shrinking medical miracle that has bought her a few years, Hazel has never been anything but terminal, her final chapter inscribed upon diagnosis. But when a gorgeous plot twist named Augustus Waters suddenly appears at Cancer Kid Support Group, Hazel s story is about to be completely rewritten.', 2010, 'https://covers.openlibrary.org/b/id/10863345-L.jpg', 1, 97, 5),
(105, 'The Anthropocene Reviewed', '', 2021, 'https://covers.openlibrary.org/b/id/12690020-L.jpg', 1, 98, 5),
(106, 'Looking for Alaska', 'Before. Miles “Pudge” Halter is done with his safe life at home. His whole life has been one big non-event, and his obsession with famous last words has only made him crave “the Great Perhaps” even more (Francois Rabelais, poet). He heads off to the sometimes crazy and anything-but-boring world of Culver Creek Boarding School, and his life becomes the opposite of safe. Because down the hall is Alaska Young. The gorgeous, clever, funny, sexy, self-destructive, screwed up, and utterly fascinating Alaska Young. She is an event unto herself. She pulls Pudge into her world, launches him into the Great Perhaps, and steals his heart. Then. . . . \r\nAfter. Nothing is ever the same', 2005, 'https://covers.openlibrary.org/b/id/12614649-L.jpg', 1, 99, 5),
(107, 'Paper towns', 'One month before graduating from his Central Florida high school, Quentin \"Q\" Jacobsen basks in the predictable boringness of his life until the beautiful and exciting Margo Roth Spiegelman, Q s neighbor and classmate, takes him on a midnight adventure and then mysteriously disappears.', 2008, 'https://covers.openlibrary.org/b/id/12713482-L.jpg', 1, 100, 5),
(108, 'Classic Horror Stories', 'Anthology contains:\r\nThe mysterious mansion / Honoré de Balzac  . \r\nMrs. Amworth / E.F. Benson  . \r\n[The damned thing](https://openlibrary.org/works/OL20084265W) / Ambrose Bierce  . \r\nThe green scarf / A.M. Burrage  . \r\nA terribly strange bed / Wilkie Collins  . \r\nThe signalman / Charles Dickens  . \r\nThe Brazilian cat / Sir Arthur Conan Doyle  . \r\nThe wind in the rose-bush / Mary E. Wilkins Freeman  . \r\nThe yellow wall-paper / Charlotte Perkins Gilman  . \r\n[Young Goodman Brown[(https://openlibrary.org/works/OL455569W) / Nathaniel Hawthorne  . \r\nThe boy who drew cats / Lafcadio Hearn  . \r\nThe gateway of the monster / W.H. Hodgson  . \r\nAdventure of the German student / Washington Irving  . \r\nThe monkey s paw / W.W. Jacobs  . \r\nThe mark of the beast / Rudyard Kipling  . \r\nVendetta / Guy de Maupassant  . \r\nNo. 17 / Edith Nesbit  . \r\n[The facts in the case of M. Valdemar](https://openlibrary.org/works/OL40987W) / Edgar Allan Poe  . \r\nThe isle of voices / Robert Louis Stevenson  . \r\nThe story of the late Mr. Elvesham  . \r\nThe lady s maid s bell / Edith Wharton.', 1999, 'https://covers.openlibrary.org/b/id/2663436-L.jpg', 1, 101, 5),
(109, 'The Martian Chronicles', 'This is a collection of science fiction short stories, cleverly cobbled together to form a coherent and very readable novel about a future colonization of Mars. As the stories progress chronologically the author tells how the first humans colonized Mars, initially sharing the planet with a handful of Martians. When Earth is devastated by nuclear war the colony is left to fend for itself and the colonists determine to build a new Earth on Mars.', 1991, 'https://covers.openlibrary.org/b/id/8775045-L.jpg', 1, 102, 5),
(110, 'Dandelion Wine', 'The summer of  28 was a vintage season for a growing boy. A summer of green apple trees, mowed lawns, and new sneakers. Of half-burnt firecrackers, of gathering dandelions, of Grandma s belly-busting dinner. It was a summer of sorrows and marvels and gold-fuzzed bees. A magical, timeless summer in the life of a twelve-year-old boy named Douglas Spaulding—remembered forever by the incomparable Ray Bradbury.\r\n\r\nDandelion Wine is unique amongst the works of the popular author Ray Bradbury, in that it provides us with perhaps the clearest insight into the thoughts and feelings of the author. The book was published in 1957, perhaps over twenty years after the era which it is about, thus providing an inevitable theme of nostalgia throughout the book. The principal character, Douglas Spalding, and his brother Tom, encounter a series of adventures which are described in a crafted and distinguished manner to provide a philosophical tone throughout the book. The narrative is enriched by the experiences of individuals such as Leo Auffman, who attempts (unsuccessfully) to construct a  Happiness machine . Overall, the book provides a nostalgic sense of childhood and an understanding of the beauty of the world and all its features; in this way, it appears to be Bradbury himself reminiscing on his past. Douglas has similar traits to those Bradbury has later in life identified in himself, strengthening this interpretation.', 1982, 'https://covers.openlibrary.org/b/id/9345421-L.jpg', 1, 103, 5);
INSERT INTO `buku` (`bu_id`, `bu_title`, `bu_synopsis`, `bu_publishedat`, `bu_image`, `bu_status`, `bu_pt_id`, `bu_rb_id`) VALUES
(111, 'The Halloween Tree', '\"A fast-moving, eerie...tale set on Halloween night. Eight costumed boys running to meet their friend Pipkin at the haunted house outside town encounter instead the huge and cadaverous Mr. Moundshroud. As Pipkin scrambles to join them, he is swept away by a dark Something, and Moundshroud leads the boys on the tail of a kite through time and space to search the past for their friend and the meaning of Halloween. After witnessing a funeral procession in ancient Egypt, cavemen discovering fire, Druid rites, the persecution of witches in the Dark Ages, and the gargoyles of Notre Dame, they catch up with the elusive Pipkin in the catacombs of Mexico, where each boy gives one year from the end of his life to save Pipkin s. Enhanced by appropriately haunting black-and-white drawings.\" . Booklist', 1972, 'https://covers.openlibrary.org/b/id/255205,254670-L.jpg', 1, 104, 5),
(112, 'The October Country', '', 1969, 'https://covers.openlibrary.org/b/id/6546094-L.jpg', 1, 105, 5),
(113, 'Thinking, fast and slow', 'Kahneman introduces two modes of thought - system 1, fast and intuitive, and system 2, slow and reasoned - and explores how these modes effect behavior, particularly judgement and decision making.', 1900, 'https://covers.openlibrary.org/b/id/12571352-L.jpg', 1, 106, 5),
(114, 'Gordon Ramsay Quick and Delicious', '', 2020, 'https://covers.openlibrary.org/b/id/10434577-L.jpg', 1, 107, 5),
(115, 'Roasting in Hell s Kitchen', 'Everyone thinks they know the real Gordon Ramsay: rude, loud, pathologically driven, stubborn as hell.For the first time, Ramsay tells the full inside story of his life and how he became the world s most famous and infamous chef: his difficult childhood, his brother s heroin addiction, his failed first career as a soccer player, his fanatical pursuit of gastronomic perfection and his TV persona—all of the things that made him the celebrated culinary talent and media powerhouse that he is today.In Roasting in Hell s Kitchen Ramsay talks frankly about his tough and emotional childhood, including his father s alcoholism and violence and their effect on his relationships with his mother and siblings. His rootless upbringing saw him moving from house to house and town to town followed by the authorities and debtors as his father lurched from one failed job to another.He recounts his short-circuited career as a soccer player, when he was signed by Scotland s premier club at the age of fifteen but then, just two years later, dropped out when injury dashed his hopes. Ramsay searched for another vocation and, much to his father s disgust, went into catering, which his father felt was meant for “poofs.”He trained under some of the most famous and talented chefs in Europe, working to exacting standards and under extreme conditions that would sometimes erupt in physical violence. But he thrived, with his exquisite palate, incredible vision and relentless work ethic. Dish by dish, restaurant by restaurant, he gradually built a Michelin-starred empire.A candid, eye-opening look into the extraordinary life and mind of an elite and unique restaurateur and chef, Roasting in Hell s Kitchen will change your perception not only of Gordon Ramsay but of the world of cuisine.', 2006, 'https://covers.openlibrary.org/b/id/47098-L.jpg', 1, 108, 5),
(116, 'Gordon Ramsay', '', 2006, 'https://covers.openlibrary.org/b/id/895427-L.jpg', 1, 109, 5),
(117, 'Jamie Oliver', '', 2001, 'https://covers.openlibrary.org/b/id/949432-L.jpg', 1, 110, 5),
(118, 'How to cook everything vegetarian', 'A definitive, one-stop vegetarian cookbook showcases more than two thousand different recipes and variations for simple meatless meals, including salads, soups, eggs and dairy, vegetables and fruit, pasta, grains, legumes, tofu and other meat substitutes.', 2011, 'https://covers.openlibrary.org/b/id/1441114-L.jpg', 1, 111, 5),
(119, 'Developing object-oriented software for the Macintosh', '', 1991, 'https://covers.openlibrary.org/b/id/4606805,3969150-L.jpg', 1, 112, 5),
(120, 'IPhone game development for dummies', 'Provides information on game development for the iPhone and iPad, covering such topics as SDK, iOS games, multiplayer games, and OpenGL.', 2010, 'https://covers.openlibrary.org/b/id/9856226-L.jpg', 1, 113, 5),
(121, 'ObjectiveC Programming for Dummies', '', 2012, 'https://covers.openlibrary.org/b/id/7838353-L.jpg', 1, 114, 5),
(122, 'Ios 6 Application Development For Dummies', '', 2012, 'https://covers.openlibrary.org/b/id/7697759-L.jpg', 1, 114, 5),
(123, 'iPad Application Development For Dummies?', 'Turn your iPad ideas into amazing apps with this exciting new guide!Whether you re app development amateur or programming professional, you ll discover how to get in on the App Store development gold rush and start developing for the iPad with this fun and easy guide. The iPad offers developers of all levels more opportunities than ever before to be a part of the app development game, and this book is your ticket to joining in the fun. You ll learn the basics of getting started, downloading the SDK, using context-based design, and filling your toolbox. Then you ll move on to using Objective-Cand Xcode to program robust and vibrant apps and games specifically for the mobile platform.Offers a plain-English guide whether you re a novice or a seasoned developer who is interested in developing iPad applicationsCovers working with the multitouch interface and in split-screen modeProvides useful advice on what applications thrive in the App Store and which have the most potential to turn a profitIncludes a companion Web site with source codePacked with helpful advice on the ins and outs of developing great apps for mobile devices, iPad Application Development For Dummies gets you started creating cool new apps right away!Note: CD-ROM/DVD and other supplementary materials are not included as part of eBook file.Note: CD-ROM/DVD and other supplementary materials are not included.The EPUB format of this title may not be compatible for use on all handheld devices.', 2010, 'https://covers.openlibrary.org/b/id/9672852-L.jpg', 1, 115, 5),
(124, 'Design Patterns for Embedded Systems in C', '', 2010, 'https://covers.openlibrary.org/b/id/7814387-L.jpg', 1, 116, 5),
(125, 'Real-time UML', '', 1997, 'https://covers.openlibrary.org/b/id/134392-L.jpg', 1, 117, 5),
(126, 'Agile Systems Engineering', '', 2015, 'https://covers.openlibrary.org/b/id/12625654-L.jpg', 1, 118, 5),
(127, 'IPad for Seniors for Dummies', '', 2012, 'https://covers.openlibrary.org/b/id/7690292-L.jpg', 1, 54, 5),
(128, 'Macs All-in-One for Dummies', 'Annotation', 2009, 'https://covers.openlibrary.org/b/id/8690006-L.jpg', 1, 54, 5),
(129, 'Billion Dollar Loser', '', 2020, 'https://covers.openlibrary.org/b/id/10862942-L.jpg', 1, 119, 5),
(130, 'Encyclopedia of Chart Patterns', 'In this revised and expanded second edition of the bestselling Encyclopedia of Chart Patterns,   Thomas Bulkowski updates the classic with new performance statistics for both bull and bear markets and 23 new patterns, including a second section devoted to ten event patterns. Bulkowski tells you how to trade the significant events  .  such as quarterly earnings announcements, retail sales, stock upgrades and downgrades  .  that shape today s trading and uses statistics to back up his approach. This comprehensive new edition is a must-have reference if you re a technical investor or trader. Place your order today.   \"The most complete reference to chart patterns available. It goes where no one has gone before. Bulkowski gives hard data on how good and bad the patterns are. A must-read for anyone that s ever looked at a chart and wondered what was happening.\"    .  Larry Williams, trader and author of Long-Term Secrets to Short-Term Trading', 2000, 'https://covers.openlibrary.org/b/id/303057-L.jpg', 1, 120, 5),
(131, 'Day Trading', '', 2020, 'https://covers.openlibrary.org/b/id/11630638-L.jpg', 1, 121, 5),
(132, 'Mutual Funds For Dummies (Mutual Funds for Dummies)', 'Expanded coverage of ETFs, fund alternatives, and Internet research   Cash in on the latest wealth-building techniques with America s 1 best-selling mutual fund book   Want to make the most of mutual funds? Personal finance expert Eric Tyson shares his time-tested investing advice, as well as updates to his fund recommendations and revised coverage of tax law changes, in this user-friendly resource. Sample fund portfolios and updated forms show you exactly how to accomplish your financial goals.     Pick the best funds and avoid losers     Assemble and maintain a portfolio     Evaluate your funds  performance     Track and invest in funds online     Fix common fund problems', 2007, 'https://covers.openlibrary.org/b/id/1240009-L.jpg', 1, 120, 5),
(133, 'House selling for dummies', '', 2007, 'https://covers.openlibrary.org/b/id/6795299-L.jpg', 1, 113, 5),
(134, 'Value Investing For Dummies', '', 2008, 'https://covers.openlibrary.org/b/id/2424474-L.jpg', 1, 114, 5),
(135, 'Taxes for Dummies', '', 2021, 'https://covers.openlibrary.org/b/id/1441414-L.jpg', 1, 122, 5),
(136, 'Personal finance for dummies', 'Now updated-the proven guide to taking control of your finances  The bestselling Personal Finance For Dummies has helped countless readers budget their funds successfully, rein in debt, and build a strong foundation for the future. Now, renowned financial counselor Eric Tyson combines his time-tested financial advice along with updates to his strategies that reflect changing market conditions, giving you a better-than-ever guide to taking an honest look at your current financial health and setting realistic goals for the future.  Inside, you ll find techniques for tracking expenditures, reducing spending, and getting out from under the burden of high-interest debt. Tyson explains the basics of investing in plain English, as well as risks, returns, investment options, and popular investment strategies. He also covers ways to save for college and special events, tame your taxes, and financially survive the twists and turns that life delivers. .    The bestselling, tried-and-true guide to taking control of finances, now updated to cover current market conditions  Provides concrete, actionable advice for anyone facing great economic hardship  Helps you avoid or get out of debt and budget funds more successfully  Eric Tyson, MBA, is a nationally recognized personal finance counselor and the author of numerous For Dummies titles, including Home Buying For Dummies, Investing For Dummies, and Mutual Funds For Dummies, among others    There s no need to stress over an uncertain economy-just read Personal Finance For Dummies and protect your financial future!', 1996, 'https://covers.openlibrary.org/b/id/521604-L.jpg', 1, 123, 5),
(137, 'Mockingjay', 'Against all odds, Katniss Everdeen has survived the Hunger Games twice. But now that she s made it out of the bloody arena alive, she s still not safe. The Capitol is angry. The Capitol wants revenge. Who do they think should pay for the unrest? Katniss. And what s worse, President Snow has made it clear that no one else is safe either. Not Katniss s family, not her friends, not the people of District 12. Powerful and haunting, this is the thrilling final installment of Suzanne Collins s groundbreaking Hunger Games trilogy. - Publisher.', 2010, 'https://covers.openlibrary.org/b/id/12646687-L.jpg', 1, 124, 5),
(138, 'The Hunger Games', 'Could you survive on your own, in the wil, with everyone out to make sure don t live to see the morning?\r\nIn the ruins of a place once known as North America lies the nation of Panem, a shining Capitol surrounded by twelve outlying districts. The Capitol is harsh and cruel and keeps the districts in line by forcing them all to send one boy and one girl between the ages of twelve and eighteen to participate in the annual Hunger Games, a fight to the death on live TV.\r\n\r\nSixteen-year-old Katniss Everdeen, who lives alone with her mother and younger sister, regards it as a death sentence when she steps forward to take her sister s place in the Games. But Katniss has been close to dead before . and survival, for her, is second nature. Without really meaning to, she becomes a contender. But if she is to win, she will have to start making choices that weight survival against humanity and life against love.', 2020, 'https://covers.openlibrary.org/b/id/12024297-L.jpg', 1, 125, 5),
(139, 'Catching Fire', 'Against all odds, Katniss Everdeen has won the annual Hunger Games with fellow district tribute Peeta Mellark. But it was a victory won by defiance of the Capitol and their harsh rules. Katniss and Peeta should be happy.\r\n\r\nAfter all, they have just won for themselves and their families a life of safety and plenty. But there are rumors of rebellion among the subjects, and Katniss and Peeta, to their horror, are the faces of that rebellion.\r\n\r\nThe Capitol is angry. The Capitol wants revenge. Suzanne Collins continues the amazing story of Katniss Everdeen in Catching Fire, the second novel of the phenomenal Hunger Games trilogy.', 2009, 'https://covers.openlibrary.org/b/id/12646685-L.jpg', 1, 126, 5),
(140, 'The Fates Divide', '', 2018, 'https://covers.openlibrary.org/b/id/12343764-L.jpg', 1, 65, 6),
(141, 'Divergent', 'Divergent is the first in a trilogy of dystopian, YA novels by Veronica Roth. The book is written from Beatrice Prior’s (Tris), point of view and is written in short chapters making it easy to put down and pick up again.\r\n\r\nThe story is fast paced with full on action throughout. It contains elements of humour and romance, alongside some seriously brutal scenes, especially during Tris’s initiation. There is also quite a few though provoking moments.\r\n\r\nThis was one of the first YA novels that I read and I found myself hooked right through to the very last word.\r\n\r\nThe scenes are described in detail giving you a clear picture and making it easy to visualise the on goings in your head.\r\n\r\nTris can be a little moody at times and doubts herself too much, but this only adds to her good nature, fun, determined and strong personality which we see blossom throughout\r\n\r\nThe ending wasn’t what I expected, thus my need to get the second book, ‘Insurgent’, straight away. I Needed to know what happened next.\r\n\r\nI surprisingly found myself enjoying Divergent much more than I first thought I would, and thus my love of YA novels began.\r\n\r\nDivergent was made into a movie back in 2014. If you have seen the film but not read the book then you are missing out on vital aspects of the plot and characters, that didn’t appear in the film. I enjoyed the film, just not as much as the book.', 2010, 'https://covers.openlibrary.org/b/id/8443818-L.jpg', 1, 127, 6),
(142, 'Nineteen Eighty-Four', 'Nineteen Eighty-Four: A Novel, often referred to as 1984, is a dystopian social science fiction novel by the English novelist George Orwell (the pen name of Eric Arthur Blair). It was published on 8 June 1949 by Secker & Warburg as Orwell s ninth and final book completed in his lifetime. Thematically, Nineteen Eighty-Four centres on the consequences of totalitarianism, mass surveillance, and repressive regimentation of persons and behaviours within society. Orwell, himself a democratic socialist, modelled the authoritarian government in the novel after Stalinist Russia. More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.\r\n\r\n .  .  .  .  . 		\r\nAlso contained in:		\r\n[Novels (Animal Farm / Burmese Days / Clergyman s Daughter / Coming Up for Air / Keep the Aspidistra Flying / Nineteen Eighty-Four)](https://openlibrary.org/works/OL1168045W)		\r\n[Novels (Animal Farm / Nineteen Eighty-Four)](https://openlibrary.org/works/OL1167981W)\r\n[Orwell s Nineteen Eighty-Four: Text, Sources, Criticism](https://openlibrary.org/works/OL1168095W)', 1984, 'https://covers.openlibrary.org/b/id/12389416-L.jpg', 1, 128, 6),
(143, 'Confessions of a Bad Mother', '', 2005, 'https://covers.openlibrary.org/b/id/10418111-L.jpg', 1, 129, 6),
(144, 'How Not To Murder Your Mother', '', 2014, 'https://covers.openlibrary.org/b/id/7573537-L.jpg', 1, 130, 6),
(145, 'Confessions of a failed grown-up', '', 2008, 'https://covers.openlibrary.org/b/id/8322454-L.jpg', 1, 131, 6),
(146, 'How to Be Perfectly Unhappy', '', 2017, 'https://covers.openlibrary.org/b/id/10675597,10675596-L.jpg', 1, 132, 6),
(147, 'My Dog The Paradox', '', 2013, 'https://covers.openlibrary.org/b/id/7863345-L.jpg', 1, 132, 6),
(148, 'Why My Cat Is More Impressive Than Your Baby', '', 2019, 'https://covers.openlibrary.org/b/id/9165716-L.jpg', 1, 133, 6),
(149, 'How to Tell If Your Cat Is Plotting to Kill You', '', 2012, 'https://covers.openlibrary.org/b/id/7264592-L.jpg', 1, 133, 6),
(150, 'If My Dogs Were a Pair of Middle-Aged Men', '', 2017, 'https://covers.openlibrary.org/b/id/10675598-L.jpg', 1, 132, 6),
(151, 'A graphical approach to precalculus with limits', '', 2003, 'https://covers.openlibrary.org/b/id/1142607-L.jpg', 1, 134, 6),
(152, 'College Algebra', '', 1900, 'https://covers.openlibrary.org/b/id/1324960-L.jpg', 1, 135, 6),
(153, 'Beginning algebra', '', 1971, 'https://covers.openlibrary.org/b/id/1175780-L.jpg', 1, 136, 6),
(154, 'Mathematics with applications', '', 1974, 'https://covers.openlibrary.org/b/id/9432757-L.jpg', 1, 137, 6),
(155, 'Intermediate algebra', '', 1979, 'https://covers.openlibrary.org/b/id/11653665-L.jpg', 1, 138, 6),
(156, 'Calculus with applications', '', 1985, 'https://covers.openlibrary.org/b/id/6731919-L.jpg', 1, 139, 6),
(157, 'Python Programming for Raspberry Pi, Sams Teach Yourself in 24 Hours', '', 2013, 'https://covers.openlibrary.org/b/id/12402101-L.jpg', 1, 49, 6),
(158, 'PHP, MySQL, and JavaScript All-In-One for Dummies', '', 2018, 'https://covers.openlibrary.org/b/id/7859252-L.jpg', 1, 54, 6),
(159, 'Arduino Programming in 24 Hours Sams Teach Yourself', '', 2014, 'https://covers.openlibrary.org/b/id/7791364-L.jpg', 1, 140, 6),
(160, 'Linux For Dummies', '', 1999, 'https://covers.openlibrary.org/b/id/520415-L.jpg', 1, 141, 6),
(161, 'The Calculus of Friendship', '', 2009, 'https://covers.openlibrary.org/b/id/10672399,8064920-L.jpg', 1, 142, 6),
(162, 'Sync', 'The tendency to synchronize may be the most mysterious and pervasive drive in all of nature. It has intrigued some of the most brilliant minds of the 20th century, including Albert Einstein, Richard Feynman, Norbert Wiener, Brian Josephson, and Arthur Winfree.\r\n\r\nAt once elegant and riveting, Sync tells the story of the dawn of a new science. Steven Strogatz, a leading mathematician in the fields of chaos and complexity theory, explains how enormous systems can synchronize themselves, from the electrons in a superconductor to the pacemaker cells in our hearts. He shows that although these phenomena might seem unrelated on the surface, at a deeper level there is a connection, forged by the unifying power of mathematics.', 2004, 'https://covers.openlibrary.org/b/id/10431937,545840,-1-L.jpg', 1, 143, 6),
(163, 'Interactive Differential Equations', '', 1996, 'https://covers.openlibrary.org/b/id/2334686-L.jpg', 1, 134, 6),
(164, 'Nonlinear Dynamics and Chaos', '', 2008, 'https://covers.openlibrary.org/b/id/12440166-L.jpg', 1, 144, 7),
(165, 'Infinite Powers', 'From preeminent math personality and author of The Joy of x, a brilliant and endlessly appealing explanation of calculus—how it works and why it makes our lives immeasurably better.\r\n\r\nWithout calculus, we wouldn’t have cell phones, TV, GPS, or ultrasound. We wouldn’t have unraveled DNA or discovered Neptune or figured out how to put 5,000 songs in your pocket.\r\n\r\nThough many of us were scared away from this essential, engrossing subject in high school and college, Steven Strogatz’s brilliantly creative, down-to-earth history shows that calculus is not about complexity; it’s about simplicity. It harnesses an unreal number—infinity—to tackle real-world problems, breaking them down into easier ones and then reassembling the answers into solutions that feel miraculous.\r\n\r\nInfinite Powers recounts how calculus tantalized and thrilled its inventors, starting with its first glimmers in ancient Greece and bringing us right up to the discovery of gravitational waves (a phenomenon predicted by calculus). Strogatz reveals how this form of math rose to the challenges of each age: how to determine the area of a circle with only sand and a stick; how to explain why Mars goes “backwards” sometimes; how to make electricity with magnets; how to ensure your rocket doesn’t miss the moon; how to turn the tide in the fight against AIDS.\r\n\r\nAs Strogatz proves, calculus is truly the language of the universe. By unveiling the principles of that language, Infinite Powers makes us marvel at the world anew.', 2019, 'https://covers.openlibrary.org/b/id/10308746-L.jpg', 1, 145, 7),
(166, 'The JOY OF COOKING', 'Privately published in 1931 by Irma S. Rombauer of St Louis, Missouri. (Just 3000 copies)\r\nFirst printed in 1936.\r\nNow over 18 million copies and its eight edition *The Joy of Cooking* is the\r\n*definitive* US cookbook.', 1931, 'https://covers.openlibrary.org/b/id/6679542-L.jpg', 1, 146, 7),
(167, 'Sun in a Bottle', 'The author of Zero looks at the messy history of the struggle to harness fusion energy .When weapons builders detonated the first hydrogen bomb in 1952, they tapped into the vastest source of energy in our solar system . the very same phenomenon that makes the sun shine. Nuclear fusion was a virtually unlimited source of power that became the center of a tragic and comic quest that has left scores of scientists battered and disgraced. For the past half-century, governments and research teams have tried to bottle the sun with lasers, magnets, sound waves, particle beams, and chunks of meta. (The latest venture, a giant, multi-billion-dollar, international fusion project called ITER, is just now getting underway.) Again and again, they have failed, disgracing generations of scientists. Throughout this fascinating journey Charles Seife introduces us to the daring geniuses, villains, and victims of fusion science: the brilliant and tortured Andrei Sakharov; the monomaniacal and Strangelovean Edward Teller; Ronald Richter, the secretive physicist whose lies embarrassed an entire country; and Stanley Pons and Martin Fleischmann, the two chemists behind the greatest scientific fiasco of the past hundred years. Sun in a Bottle is the first major book to trace the story of fusion from its beginnings into the 21st century, of how scientists have gotten burned by trying to harness the power of the sun.', 2008, 'https://covers.openlibrary.org/b/id/6434246-L.jpg', 1, 21, 7),
(168, 'Proofiness', 'In the tradition of Stephen Colbert s concept of truthiness, Proofiness explores the intersection of chicanery and mathematics. \r\n\r\nThe author explores regression, false correlation, Potemkin numbers, and a variety of other sketchy techniques used to make people think that the data reflect patterns that don t exist in actuality.\r\n\r\nHow to Lie With Statistics would strike me as a readalike.', 2010, 'https://covers.openlibrary.org/b/id/9968202-L.jpg', 1, 147, 7),
(169, 'Virtual Unrealities', '', 1997, 'https://covers.openlibrary.org/b/id/421459-L.jpg', 1, 148, 7),
(170, 'Sun in a Bottle', 'The author of Zero looks at the messy history of the struggle to harness fusion energy .When weapons builders detonated the first hydrogen bomb in 1952, they tapped into the vastest source of energy in our solar system . the very same phenomenon that makes the sun shine. Nuclear fusion was a virtually unlimited source of power that became the center of a tragic and comic quest that has left scores of scientists battered and disgraced. For the past half-century, governments and research teams have tried to bottle the sun with lasers, magnets, sound waves, particle beams, and chunks of meta. (The latest venture, a giant, multi-billion-dollar, international fusion project called ITER, is just now getting underway.) Again and again, they have failed, disgracing generations of scientists. Throughout this fascinating journey Charles Seife introduces us to the daring geniuses, villains, and victims of fusion science: the brilliant and tortured Andrei Sakharov; the monomaniacal and Strangelovean Edward Teller; Ronald Richter, the secretive physicist whose lies embarrassed an entire country; and Stanley Pons and Martin Fleischmann, the two chemists behind the greatest scientific fiasco of the past hundred years. Sun in a Bottle is the first major book to trace the story of fusion from its beginnings into the 21st century, of how scientists have gotten burned by trying to harness the power of the sun.', 2008, 'https://covers.openlibrary.org/b/id/6434246-L.jpg', 1, 21, 7),
(171, 'Decoding the Universe', 'The author of Zero explains the scientific revolution that is transforming the way we understand our worldPreviously the domain of philosophers and linguists, information theory has now moved beyond the province of code breakers to become the crucial science of our time. In Decoding the Universe, Charles Seife draws on his gift for making cutting-edge science accessible to explain how this new tool is deciphering everything from the purpose of our DNA to the parallel universes of our Byzantine cosmos. The result is an exhilarating adventure that deftly combines cryptology, physics, biology, and mathematics to cast light on the new understanding of the laws that govern life and the universe.', 2005, 'https://covers.openlibrary.org/b/id/400573-L.jpg', 1, 149, 7),
(172, 'Towards Zero', 'What is the connection between a failed suicide attempt, a wrongful accusation of theft against a schoolgirl, and the romantic life of a tennis player? To the casual observer, apparently nothing. When a houseparty gathers at Gull s Point, the seaside home of an elderly widow, earlier events come to a dramatic head.Robert Graves, author of I Claudius, was a neighbour of Agatha Christie s in Devon during the Second World War and the two became friends. Christie dedicated this book to Graves: \"Dear Robert, Since you are kind enough to say you like my stories, I venture to dedicate this book to you. All I ask is that you sternly restrain your critical faculties (doubtless sharpened by your recent excesses in that line!) when reading it. This is a story for your pleasure and not a candidate for Mr Graves  literary pillory!\" The book was dramatised by Agatha Christie and Gerald Verner. It was adapted for TV in 2007 with Geraldine McEwan as Miss Marple.', 2004, 'https://covers.openlibrary.org/b/id/12379571-L.jpg', 1, 150, 7),
(173, 'George and the Unbreakable Code', 'Banks are handing out free money, supermarkets aren t able to charge for their produce so people are getting free food, and aircrafts are refusing to fly. It looks like the world s biggest and best computers have all been hacked. And no one knows why  It s up to George and Annie to travel further into space than ever before in order to find out what or who is behind it.', 2014, 'https://covers.openlibrary.org/b/id/7464271-L.jpg', 1, 151, 7),
(174, 'God Created the Integers', '', 2005, 'https://covers.openlibrary.org/b/id/513699-L.jpg', 1, 152, 7),
(175, 'The Fabric of the Cosmos', '', 2004, 'https://covers.openlibrary.org/b/id/467778-L.jpg', 1, 153, 7),
(176, 'Icarus at the Edge of Time', '', 2008, 'https://covers.openlibrary.org/b/id/7108781-L.jpg', 1, 154, 7),
(177, 'The Hidden Reality', '', 2011, 'https://covers.openlibrary.org/b/id/10352216-L.jpg', 1, 155, 7),
(178, 'Why science matters', '', 2005, 'https://covers.openlibrary.org/b/id/1752726,1752619-L.jpg', 1, 156, 7),
(179, 'Towards Understanding the Climate of Venus', '', 2012, 'https://covers.openlibrary.org/b/id/9415211-L.jpg', 1, 157, 7),
(180, 'Chasing New Horizons', '', 2018, 'https://covers.openlibrary.org/b/id/8802315-L.jpg', 1, 158, 7),
(181, 'Lonely Planet Corcega (Lonely Planet)', '', 2001, 'https://covers.openlibrary.org/b/id/3324712-L.jpg', 1, 159, 7),
(182, 'Biology: Concepts and Connections', '', 1999, 'https://covers.openlibrary.org/b/id/4997469-L.jpg', 1, 160, 7),
(183, 'Essential biology with physiology', '', 2018, 'https://covers.openlibrary.org/b/id/4694345-L.jpg', 1, 161, 7),
(184, 'Investigating biology', '', 1993, 'https://covers.openlibrary.org/b/id/5015663-L.jpg', 1, 162, 7),
(185, 'The four feathers', 'British guardsman Harry Feversham stuns his friends when, just before he is scheduled to ship off to the Sudan, he quits his regiment. In shocked retaliation for this dastardly act of cowardice, Harry is presented with four feathers: one from each of his three closest regimental friends and the fourth-and the most devastating-from his fiancée.\r\n\r\nDetermined to prove his bravery-and to clear his name-Harry embarks for the Sudan. In search of service . . . and of honor.', 2004, 'https://covers.openlibrary.org/b/id/10034392-L.jpg', 1, 163, 7),
(186, 'Imperfect oracle', '\"Explores the relationships between science and other societal sectors, notably law, religion, government and public culture, in terms of the concepts of expert and moral authority\" . Provided by publisher.', 2009, 'https://covers.openlibrary.org/b/id/6389493-L.jpg', 1, 164, 7),
(187, 'Chemistry', 'The book provides the basis of modern chemistry that every student needs for their professional development and as preparation for more complex chemistry courses. It also offers features that facilitate learning and serve as a guide for students to acquire a conceptual understanding and the skills needed to solve problems. The first five chapters offer a microscopic and phenomenological view of chemistry, while the latter review the chemistry of nonmetals, metals, organic chemistry and biochemistry.', 1988, 'https://covers.openlibrary.org/b/id/10858940-L.jpg', 1, 165, 7),
(188, 'Chemoinformatics', '', 2004, 'https://covers.openlibrary.org/b/id/12438153-L.jpg', 1, 54, 8),
(189, 'Thermodynamics, Statistical Thermodynamics, and Kinetics', '', 2009, 'https://covers.openlibrary.org/b/id/1520248-L.jpg', 1, 49, 8),
(190, 'Quantum Chemistry and Spectroscopy', '', 2009, 'https://covers.openlibrary.org/b/id/581951-L.jpg', 1, 49, 8),
(191, 'Physical chemistry', '', 1955, 'https://covers.openlibrary.org/b/id/9864870-L.jpg', 1, 113, 8),
(192, 'Fluid mechanics for engineers', '', 1957, 'https://covers.openlibrary.org/b/id/8900741-L.jpg', 1, 166, 8),
(193, 'Water quality engineering in natural systems', 'FOCUSING ON CONTAMINANT FATE AND TRANSPORT, DESIGN OF ENVIRONMENTAL-CONTROL SYSTEMS, AND REGULATORY CONSTRAINTS    This textbook details the fundamental equations that describe the fate and transport of contaminantsin the water environment. The application of these fundamental equations to the design of environmental-control systems and methodologies for assessing the impact of contaminant discharges into rivers, lakes, wetlands, ground water, and oceans are all covered. Readers learn to assess how much waste can be safely assimilatedinto a water body by developing a solid understanding of the relationship between the type of pollutant discharged, the characteristics of the receiving water, and physical, chemical, and biological impacts. In cases of surface runoff from urban and agricultural watersheds, quantitative relationships between the quality of surface runoff and the characteristics of contaminant sources located within the watersheds are presented.    Some of the text s distinguishing features include its emphasis on the engineering design of systems that control the fate and transport of contaminants in the water environment, the design of remediation systems, and regulatory constraints. Particular attention is given to use-attainability analyses and the estimation of total maximum daily loads, both of which are essential components of water-quality control in natural systems. Readers are provided with a thorough explanation of the complex set of laws and regulations governing water-quality control in the United States.    Proven as an effective textbook in several offerings of the author s class \"Water Quality Control in Natural Systems,\" the flow of the text is carefully structured to facilitate learning. Moreover, a number of practical pedagogical tools are offered:   Practical examples used throughout the text illustrate the effects of controlling the quality, quantity, timing, and distribution of contaminant discharges into the environment   End-of-ch', 2006, 'https://covers.openlibrary.org/b/id/1250128-L.jpg', 1, 122, 8),
(194, 'Water-Resources Engineering', '', 1999, 'https://covers.openlibrary.org/b/id/134480-L.jpg', 1, 160, 8);

-- --------------------------------------------------------

--
-- Table structure for table `buku_penulis`
--

DROP TABLE IF EXISTS `buku_penulis`;
CREATE TABLE `buku_penulis` (
  `bp_id` int(11) NOT NULL,
  `bp_bu_id` int(11) NOT NULL,
  `bp_ps_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buku_penulis`
--

INSERT INTO `buku_penulis` (`bp_id`, `bp_bu_id`, `bp_ps_id`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 1),
(5, 5, 1),
(6, 6, 1),
(7, 7, 1),
(8, 8, 2),
(9, 9, 3),
(10, 10, 4),
(11, 11, 4),
(12, 11, 5),
(13, 12, 6),
(14, 13, 6),
(15, 13, 7),
(16, 13, 8),
(17, 13, 9),
(18, 13, 10),
(19, 13, 11),
(20, 13, 12),
(21, 13, 13),
(22, 13, 14),
(23, 13, 15),
(24, 13, 16),
(25, 13, 17),
(26, 13, 18),
(27, 13, 19),
(28, 13, 20),
(29, 13, 21),
(30, 13, 22),
(31, 13, 23),
(32, 13, 24),
(33, 13, 10),
(34, 13, 25),
(35, 13, 17),
(36, 14, 26),
(37, 14, 6),
(38, 14, 27),
(39, 14, 28),
(40, 14, 29),
(41, 14, 30),
(42, 14, 31),
(43, 14, 32),
(44, 14, 33),
(45, 14, 34),
(46, 14, 19),
(47, 14, 35),
(48, 14, 36),
(49, 14, 37),
(50, 14, 38),
(51, 14, 39),
(52, 14, 40),
(53, 14, 41),
(54, 14, 42),
(55, 14, 43),
(56, 14, 44),
(57, 14, 45),
(58, 14, 46),
(59, 14, 47),
(60, 14, 48),
(61, 14, 49),
(62, 14, 50),
(63, 14, 10),
(64, 14, 51),
(65, 14, 52),
(66, 14, 53),
(67, 14, 54),
(68, 14, 55),
(69, 14, 56),
(70, 14, 57),
(71, 14, 58),
(72, 14, 59),
(73, 14, 60),
(74, 14, 61),
(75, 14, 62),
(76, 14, 63),
(77, 14, 64),
(78, 14, 65),
(79, 14, 11),
(80, 14, 66),
(81, 14, 67),
(82, 14, 68),
(83, 15, 69),
(84, 16, 70),
(85, 17, 6),
(86, 17, 71),
(87, 18, 20),
(88, 19, 72),
(89, 20, 72),
(90, 20, 73),
(91, 20, 74),
(92, 21, 72),
(93, 22, 75),
(94, 23, 72),
(95, 24, 72),
(96, 25, 72),
(97, 26, 74),
(98, 27, 74),
(99, 28, 74),
(100, 29, 74),
(101, 30, 74),
(102, 30, 76),
(103, 30, 77),
(104, 31, 78),
(105, 32, 79),
(106, 32, 74),
(107, 33, 80),
(108, 34, 80),
(109, 35, 81),
(110, 36, 82),
(111, 37, 83),
(112, 37, 84),
(113, 37, 85),
(114, 37, 86),
(115, 37, 87),
(116, 37, 88),
(117, 38, 83),
(118, 39, 89),
(119, 40, 89),
(120, 41, 90),
(121, 41, 91),
(122, 41, 92),
(123, 41, 93),
(124, 41, 94),
(125, 42, 90),
(126, 42, 91),
(127, 42, 92),
(128, 42, 93),
(129, 42, 94),
(130, 43, 95),
(131, 44, 96),
(132, 45, 96),
(133, 46, 96),
(134, 47, 96),
(135, 48, 97),
(136, 49, 97),
(137, 50, 98),
(138, 51, 97),
(139, 52, 99),
(140, 52, 100),
(141, 53, 99),
(142, 54, 101),
(143, 55, 99),
(144, 56, 102),
(145, 56, 103),
(146, 57, 102),
(147, 58, 102),
(148, 59, 102),
(149, 60, 104),
(150, 61, 105),
(151, 62, 105),
(152, 63, 105),
(153, 64, 106),
(154, 65, 53),
(155, 66, 107),
(156, 66, 108),
(157, 67, 54),
(158, 68, 109),
(159, 69, 109),
(160, 69, 110),
(161, 70, 111),
(162, 71, 111),
(163, 72, 111),
(164, 73, 9),
(165, 74, 9),
(166, 75, 9),
(167, 76, 9),
(168, 77, 9),
(169, 78, 9),
(170, 79, 9),
(171, 79, 112),
(172, 80, 9),
(173, 81, 9),
(174, 82, 113),
(175, 83, 113),
(176, 84, 113),
(177, 84, 114),
(178, 85, 115),
(179, 86, 115),
(180, 87, 115),
(181, 87, 116),
(182, 88, 115),
(183, 89, 115),
(184, 90, 115),
(185, 91, 115),
(186, 92, 115),
(187, 93, 117),
(188, 94, 117),
(189, 95, 118),
(190, 96, 119),
(191, 97, 120),
(192, 98, 120),
(193, 99, 120),
(194, 100, 121),
(195, 101, 121),
(196, 102, 121),
(197, 103, 121),
(198, 104, 122),
(199, 105, 122),
(200, 106, 122),
(201, 107, 122),
(202, 108, 123),
(203, 108, 11),
(204, 108, 59),
(205, 108, 9),
(206, 108, 34),
(207, 108, 46),
(208, 108, 66),
(209, 109, 19),
(210, 110, 19),
(211, 111, 19),
(212, 112, 19),
(213, 113, 124),
(214, 114, 125),
(215, 115, 125),
(216, 116, 126),
(217, 117, 127),
(218, 117, 128),
(219, 118, 129),
(220, 119, 130),
(221, 119, 131),
(222, 119, 132),
(223, 120, 130),
(224, 121, 130),
(225, 122, 133),
(226, 123, 130),
(227, 123, 134),
(228, 124, 135),
(229, 125, 135),
(230, 125, 136),
(231, 126, 135),
(232, 127, 137),
(233, 128, 138),
(234, 129, 139),
(235, 130, 140),
(236, 131, 141),
(237, 132, 142),
(238, 133, 143),
(239, 133, 144),
(240, 134, 145),
(241, 135, 143),
(242, 136, 143),
(243, 137, 146),
(244, 137, 146),
(245, 138, 146),
(246, 139, 146),
(247, 140, 147),
(248, 141, 147),
(249, 142, 148),
(250, 143, 149),
(251, 144, 149),
(252, 145, 149),
(253, 146, 150),
(254, 147, 150),
(255, 148, 150),
(256, 149, 150),
(257, 150, 150),
(258, 151, 151),
(259, 152, 152),
(260, 153, 153),
(261, 154, 153),
(262, 154, 154),
(263, 154, 155),
(264, 155, 156),
(265, 156, 153),
(266, 157, 157),
(267, 157, 158),
(268, 158, 157),
(269, 159, 157),
(270, 160, 159),
(271, 160, 160),
(272, 160, 161),
(273, 161, 162),
(274, 162, 162),
(275, 163, 163),
(276, 164, 162),
(277, 165, 162),
(278, 166, 164),
(279, 166, 165),
(280, 166, 166),
(281, 166, 167),
(282, 166, 168),
(283, 166, 169),
(284, 167, 170),
(285, 168, 170),
(286, 169, 171),
(287, 170, 170),
(288, 171, 170),
(289, 172, 115),
(290, 173, 172),
(291, 173, 173),
(292, 174, 173),
(293, 175, 174),
(294, 176, 174),
(295, 177, 174),
(296, 178, 175),
(297, 179, 176),
(298, 179, 177),
(299, 179, 178),
(300, 179, 179),
(301, 179, 180),
(302, 179, 181),
(303, 180, 182),
(304, 180, 178),
(305, 181, 183),
(306, 182, 184),
(307, 183, 185),
(308, 183, 186),
(309, 183, 187),
(310, 184, 188),
(311, 185, 189),
(312, 186, 190),
(313, 187, 190),
(314, 187, 191),
(315, 187, 192),
(316, 187, 193),
(317, 187, 194),
(318, 188, 195),
(319, 188, 196),
(320, 189, 195),
(321, 189, 197),
(322, 190, 195),
(323, 191, 198),
(324, 191, 199),
(325, 191, 200),
(326, 192, 201),
(327, 193, 201),
(328, 194, 201);

-- --------------------------------------------------------

--
-- Table structure for table `denda`
--

DROP TABLE IF EXISTS `denda`;
CREATE TABLE `denda` (
  `de_id` int(11) NOT NULL,
  `de_nama` varchar(100) NOT NULL,
  `de_harga` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `detaildenda`
--

DROP TABLE IF EXISTS `detaildenda`;
CREATE TABLE `detaildenda` (
  `dd_id` int(11) NOT NULL,
  `dd_hp_id` int(11) NOT NULL,
  `dd_de_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `dpinjam`
--

DROP TABLE IF EXISTS `dpinjam`;
CREATE TABLE `dpinjam` (
  `dp_id` int(11) NOT NULL,
  `dp_bu_id` int(11) NOT NULL,
  `dp_hp_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
CREATE TABLE `genre` (
  `ge_id` int(11) NOT NULL,
  `ge_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `genre`
--

INSERT INTO `genre` (`ge_id`, `ge_name`) VALUES
(1, 'Architecture'),
(2, 'Music'),
(3, 'Photography'),
(4, 'Fantasy'),
(5, 'Mystery'),
(6, 'Romance'),
(7, 'Horror'),
(8, 'Psychology'),
(9, 'Cooking'),
(10, 'Programming'),
(11, 'Finance'),
(12, 'Science Fiction'),
(13, 'Fiction'),
(14, 'Humor'),
(15, 'Mathematics'),
(16, 'Physics'),
(17, 'Biology'),
(18, 'Chemistry'),
(19, 'Science');

-- --------------------------------------------------------

--
-- Table structure for table `genre_buku`
--

DROP TABLE IF EXISTS `genre_buku`;
CREATE TABLE `genre_buku` (
  `gb_id` int(11) NOT NULL,
  `gb_bu_id` int(11) NOT NULL,
  `gb_ge_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `genre_buku`
--

INSERT INTO `genre_buku` (`gb_id`, `gb_bu_id`, `gb_ge_id`) VALUES
(1, 1, 4),
(2, 1, 13),
(3, 2, 13),
(4, 2, 4),
(5, 3, 13),
(6, 3, 4),
(7, 4, 13),
(8, 4, 4),
(9, 5, 13),
(10, 5, 4),
(11, 6, 13),
(12, 6, 4),
(13, 7, 13),
(14, 7, 4),
(15, 8, 8),
(16, 9, 8),
(17, 10, 11),
(18, 11, 11),
(19, 12, 13),
(20, 12, 7),
(21, 13, 13),
(22, 14, 7),
(23, 15, 13),
(24, 16, 13),
(25, 16, 7),
(26, 17, 13),
(27, 17, 5),
(28, 17, 4),
(29, 17, 7),
(30, 18, 13),
(31, 19, 8),
(32, 20, 8),
(33, 21, 11),
(34, 22, 8),
(35, 23, 11),
(36, 24, 8),
(37, 24, 11),
(38, 25, 8),
(39, 26, 8),
(40, 27, 8),
(41, 28, 8),
(42, 29, 8),
(43, 30, 8),
(44, 31, 8),
(45, 32, 8),
(46, 33, 14),
(47, 34, 14),
(48, 35, 1),
(49, 36, 1),
(50, 37, 1),
(51, 38, 1),
(52, 39, 2),
(53, 40, 1),
(54, 41, 2),
(55, 42, 2),
(56, 43, 2),
(57, 44, 3),
(58, 45, 3),
(59, 46, 3),
(60, 47, 3),
(61, 48, 3),
(62, 48, 10),
(63, 49, 3),
(64, 49, 10),
(65, 50, 10),
(66, 51, 10),
(67, 52, 3),
(68, 53, 3),
(69, 54, 3),
(70, 55, 3),
(71, 56, 3),
(72, 57, 3),
(73, 58, 3),
(74, 59, 3),
(75, 60, 13),
(76, 61, 13),
(77, 61, 4),
(78, 62, 13),
(79, 63, 13),
(80, 63, 4),
(81, 64, 13),
(82, 65, 13),
(83, 66, 13),
(84, 66, 4),
(85, 67, 13),
(86, 67, 4),
(87, 68, 4),
(88, 68, 13),
(89, 69, 13),
(90, 69, 4),
(91, 70, 13),
(92, 71, 4),
(93, 71, 13),
(94, 72, 6),
(95, 73, 13),
(96, 73, 5),
(97, 74, 13),
(98, 74, 5),
(99, 75, 13),
(100, 75, 5),
(101, 76, 13),
(102, 76, 4),
(103, 76, 5),
(104, 77, 13),
(105, 78, 13),
(106, 78, 5),
(107, 79, 13),
(108, 79, 5),
(109, 80, 13),
(110, 80, 5),
(111, 81, 13),
(112, 81, 5),
(113, 82, 13),
(114, 82, 5),
(115, 83, 13),
(116, 83, 5),
(117, 84, 13),
(118, 84, 5),
(119, 85, 13),
(120, 85, 5),
(121, 85, 6),
(122, 86, 5),
(123, 86, 13),
(124, 87, 13),
(125, 87, 5),
(126, 88, 5),
(127, 88, 13),
(128, 89, 13),
(129, 89, 5),
(130, 90, 13),
(131, 90, 5),
(132, 91, 13),
(133, 91, 5),
(134, 92, 13),
(135, 92, 5),
(136, 92, 6),
(137, 93, 13),
(138, 93, 12),
(139, 93, 6),
(140, 94, 13),
(141, 94, 12),
(142, 94, 6),
(143, 95, 13),
(144, 95, 6),
(145, 96, 13),
(146, 96, 6),
(147, 97, 13),
(148, 98, 13),
(149, 98, 6),
(150, 99, 6),
(151, 99, 13),
(152, 100, 6),
(153, 100, 13),
(154, 101, 6),
(155, 101, 13),
(156, 102, 13),
(157, 102, 6),
(158, 103, 13),
(159, 104, 6),
(160, 104, 13),
(161, 105, 19),
(162, 106, 13),
(163, 107, 13),
(164, 107, 6),
(165, 108, 13),
(166, 109, 13),
(167, 110, 13),
(168, 111, 13),
(169, 112, 7),
(170, 112, 13),
(171, 113, 8),
(172, 114, 9),
(173, 115, 9),
(174, 116, 9),
(175, 117, 9),
(176, 118, 9),
(177, 119, 10),
(178, 120, 10),
(179, 121, 10),
(180, 122, 10),
(181, 123, 10),
(182, 124, 10),
(183, 125, 10),
(184, 126, 10),
(185, 127, 10),
(186, 128, 10),
(187, 129, 11),
(188, 130, 11),
(189, 131, 11),
(190, 132, 11),
(191, 133, 11),
(192, 134, 11),
(193, 135, 11),
(194, 136, 11),
(195, 137, 13),
(196, 138, 13),
(197, 139, 4),
(198, 139, 13),
(199, 140, 13),
(200, 140, 12),
(201, 141, 13),
(202, 141, 6),
(203, 142, 13),
(204, 142, 4),
(205, 143, 13),
(206, 143, 14),
(207, 144, 14),
(208, 145, 14),
(209, 146, 14),
(210, 147, 14),
(211, 148, 14),
(212, 149, 14),
(213, 150, 14),
(214, 151, 15),
(215, 152, 15),
(216, 153, 15),
(217, 154, 15),
(218, 155, 15),
(219, 156, 15),
(220, 157, 10),
(221, 158, 10),
(222, 159, 10),
(223, 160, 10),
(224, 161, 15),
(225, 162, 16),
(226, 163, 15),
(227, 164, 15),
(228, 164, 16),
(229, 164, 17),
(230, 164, 18),
(231, 165, 15),
(232, 166, 9),
(233, 167, 19),
(234, 168, 15),
(235, 169, 13),
(236, 169, 12),
(237, 170, 19),
(238, 171, 19),
(239, 172, 13),
(240, 173, 16),
(241, 174, 15),
(242, 175, 16),
(243, 176, 13),
(244, 177, 16),
(245, 178, 8),
(246, 178, 19),
(247, 179, 16),
(248, 180, 16),
(249, 181, 13),
(250, 182, 17),
(251, 183, 17),
(252, 183, 8),
(253, 183, 19),
(254, 184, 17),
(255, 184, 19),
(256, 185, 13),
(257, 186, 19),
(258, 187, 18),
(259, 188, 18),
(260, 189, 16),
(261, 190, 18),
(262, 190, 17),
(263, 190, 16),
(264, 191, 16),
(265, 191, 18),
(266, 192, 16),
(267, 193, 18),
(268, 193, 19),
(269, 194, 16);

-- --------------------------------------------------------

--
-- Table structure for table `hpinjam`
--

DROP TABLE IF EXISTS `hpinjam`;
CREATE TABLE `hpinjam` (
  `hp_id` int(11) NOT NULL,
  `hp_borrowedat` date NOT NULL DEFAULT current_timestamp(),
  `hp_returnat` date NOT NULL,
  `hp_status` int(11) NOT NULL,
  `hp_me_id` int(11) NOT NULL,
  `hp_pe_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

DROP TABLE IF EXISTS `member`;
CREATE TABLE `member` (
  `me_id` int(11) NOT NULL,
  `me_name` varchar(100) NOT NULL,
  `me_username` varchar(20) NOT NULL,
  `me_password` varchar(256) NOT NULL,
  `me_telephone` varchar(20) NOT NULL,
  `me_address` varchar(100) NOT NULL,
  `me_registeredat` date NOT NULL,
  `me_status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`me_id`, `me_name`, `me_username`, `me_password`, `me_telephone`, `me_address`, `me_registeredat`, `me_status`) VALUES
(1, 'Argono Megantara', 'ArznoMegantara', '7d13723a4fbc7462f0e881d36a6faa99', '3544674123', 'Gang Raya Setiabudhi No. 17', '2019-05-24', 1),
(2, 'Samiah Nuraini', 'SawaNti3j', 'db9433e5aaed6d3584b11f1c9f07754a', '8943933056', 'Gg. Wonoayu No. 47', '2003-01-20', 1),
(3, 'Amy Mandasari', 'pMndztiig6', '746b3d77f3ca782aa1ea38ba46137847', '5488309260', 'Jalan Gedebage Selatan No. 53', '2011-12-03', 1),
(4, 'Azalea Uyainah', 'glafinahd', 'b2581745d08c80d9928fb691fb18c893', '7543500824', 'Gang M.T Haryono No. 069', '2013-04-06', 1),
(5, 'Rahayu Widiastuti', 'RahayWidistutahayuWi', 'a634d65b1c2f9b7f97a39fa6c117ace4', '9504206824', 'Gg. Lembong No. 737', '2008-11-03', 1),
(6, 'Leah Riyanti', 'LeahRiyanti', 'dff42ee163645ffe54a167be8baf65e7', '2862563662', 'Jalan Dipatiukur No. 09', '2001-12-05', 1),
(7, 'Amber Purwanti', 'bePrwaaiuv0rf', 'dcc1520b30ac502b3e54d2ab4299a673', '3915808870', 'Jalan Siliwangi No. 6', '2008-11-04', 1),
(8, 'Lauren Nasyidah', 'aurenNasue', 'e206c3aed2eb8a327cec6d42829b3fe3', '1245942687', 'Gg. Kapten Muslihat No. 0', '2002-12-23', 1),
(9, 'Yolanda Nasyiah', 'Yolndasuho', '3696243b6556881f5415f0e0f1bb4db7', '7416985148', 'Jl. Pelajar Pejuang No. 73', '2013-02-05', 1),
(10, 'Sergio Jailani', 'SergioJailan', 'e5fef3678d58420cbf95ff5bb12ccac9', '5242014710', 'Gg. Asia Afrika No. 95', '2009-05-22', 1),
(11, 'Mala Zulaika', 'MalaZulaika', 'ed4cf0821eccd447774c0c14fe808a97', '4938570029', 'Gg. Sukabumi No. 925', '2010-12-04', 1),
(12, 'Deborah Handayani', 'DeborahHandayanis9', '647ff4f8c111541e5b0f3bce947dddff', '6657494141', 'Jalan Surapati No. 25', '2004-07-09', 1),
(13, 'Lisa Puspita', 'nsaPsitlaPspa2e', 'b61d3d4e833f814856347cdb3b2df409', '7053126538', 'Jl. Dipatiukur No. 11', '2008-01-14', 1),
(14, 'Heather Yuliarti', 'HelherYulimtid3z', 'd5bd3461f15f3950481735795b1cdc8c', '8568638516', 'Jl. Monginsidi No. 62', '2006-10-25', 1),
(15, 'Christopher Firmansyah', 'Chrlopherirmanah8k', 'd47f1b853a7bad7e2f3520d17bab4310', '9255548376', 'Gg. Sukajadi No. 0', '2011-08-05', 1),
(16, 'Michele Kuswandari', 'MictKswandug', 'b2a2d40a4e79bd82b1bcd7dae661d633', '2992692987', 'Jalan Suryakencana No. 1', '2012-01-10', 1),
(17, 'Michelle Andriani', 'MichellAndrwoa', '5b67c4d386c6997994c7fb600479a0b2', '9912863011', 'Gang Kutai No. 3', '2007-05-12', 1),
(18, 'Heidi Usada', 'Hjdisada', '3493470654dd1a55edfd55674153a7d0', '6468648709', 'Jalan Pasir Koja No. 68', '2011-05-28', 1),
(19, 'Jessica Maryati', 'JesifMaryatp', '1296ce3ebe975fdc0df4cc2325d9df8e', '9055998135', 'Gg. Kiaracondong No. 7', '2003-01-02', 1),
(20, 'Hasan Wibisono', 'anibsonob', 'd1e81ccca717601551013286bf564581', '8367587363', 'Jalan Pacuan Kuda No. 14', '2017-09-20', 1),
(21, 'Pia Melani', 'PiaMelani', '2a04944b06bc22ae719c76660cbdf06e', '1797757042', 'Jl. Jayawijaya No. 0', '2011-04-25', 1),
(22, 'Brian Hidayat', 'BrianHidayamrianHida', 'c2122f50e0ac8390635f66fc95f46aa3', '7067526967', 'Jalan Lembong No. 87', '2008-04-15', 1),
(23, 'Gary Jailani', 'GayJilans', '76fa3d8b32aa99c306329dc409fd29a1', '4615310376', 'Gang Sadang Serang No. 742', '2021-09-10', 1),
(24, 'Ghaliyati Yuliarti', 'Ghliguid90', 'd2dafea4eb1580b55cbfcaa8d8abf7e7', '1638319052', 'Jalan Moch. Toha No. 558', '2022-01-05', 1),
(25, 'Embuh Hardiansyah', 'EmbuhHardinsyah', '673db17bed5d704765c455e775d9e3b1', '9164779091', 'Gg. Laswi No. 906', '2007-02-25', 1),
(26, 'Hasta Megantara', 'HasaMegantara', '56829899840d15c633ee60b2f2863c08', '4320448774', 'Jl. Pasteur No. 008', '2007-06-03', 1),
(27, 'Gregory Latupono', 'GegoyLatubyw56', '29de7a9f16c6f114b9ebc3ae47ff3102', '1992047631', 'Gg. Sukabumi No. 04', '2005-07-20', 1),
(28, 'Francis Natsir', 'ranksNatsir', 'e6492829822bb7433d993c71562d0766', '3166686041', 'Jl. Stasiun Wonokromo No. 6', '2003-12-05', 1),
(29, 'Lindsay Pudjiastuti', 'Lindludjiytub6', 'bbc63eccbab38ef2494d5bdd30c86e82', '6638050916', 'Jl. Cikapayang No. 595', '2011-06-14', 1),
(30, 'Blake Haryanto', 'BlaeHayatdq', 'acf12851f18102aa1282aa9a9421a3e9', '7254365059', 'Jalan Kebonjati No. 791', '2013-04-18', 1);

-- --------------------------------------------------------

--
-- Table structure for table `pegawai`
--

DROP TABLE IF EXISTS `pegawai`;
CREATE TABLE `pegawai` (
  `pe_id` int(11) NOT NULL,
  `pe_name` varchar(100) NOT NULL,
  `pe_username` varchar(20) NOT NULL,
  `pe_password` varchar(256) NOT NULL,
  `pe_position` varchar(50) NOT NULL,
  `pe_address` varchar(100) NOT NULL,
  `pe_telephone` varchar(20) NOT NULL,
  `pe_registeredat` date NOT NULL,
  `pe_status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pegawai`
--

INSERT INTO `pegawai` (`pe_id`, `pe_name`, `pe_username`, `pe_password`, `pe_position`, `pe_address`, `pe_telephone`, `pe_registeredat`, `pe_status`) VALUES
(1, 'Kenny Kosmas', 'kosmasu', 'e0c4cb97dc8c1b9a2546c7c155cf178a', 'admin', 'jalan airlangga 20', '01234567890', '2022-05-01', 1);

-- --------------------------------------------------------

--
-- Table structure for table `penerbit`
--

DROP TABLE IF EXISTS `penerbit`;
CREATE TABLE `penerbit` (
  `pt_id` int(11) NOT NULL,
  `pt_name` varchar(100) NOT NULL,
  `pt_address` varchar(100) NOT NULL,
  `pt_telephone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `penerbit`
--

INSERT INTO `penerbit` (`pt_id`, `pt_name`, `pt_address`, `pt_telephone`) VALUES
(1, 'Editora Rocco Ltda.', 'Istanbul, Turkey', '818908305'),
(2, 'Albatros', 'New York, USA', '144328264'),
(3, 'Sayzansha', '', '568614667'),
(4, 'Large Print Press', 'London, Great Britain', '235818984'),
(5, 'Bloomsbury Publishing (UK) ', 'Vancouver, Canada', '842666065'),
(6, 'Lectorum Publications', 'New York, USA', '943197046'),
(7, 'Bloomsbury Publishing, Limited', 'Kaapstad', '302599265'),
(8, 'Harpercollins', '', '656837028'),
(9, 'Penguin Random House USA', '', '279315498'),
(10, 'Simon & Schuster Audio', '', '936109057'),
(11, 'Warner Books ED', 'Buenos Aires', '701836683'),
(12, 'Hodder & Stoughton', '', '700717178'),
(13, 'Heyne Verlag', 'London', '544834333'),
(14, 'Grafton', '', '640971013'),
(15, 'Random House (a)', '', '763325133'),
(16, 'Alfred Publishing Company', '', '527721181'),
(17, 'Random House Large Print', '', '255941798'),
(18, 'Alfaguara Ediciones, S.A. (Spain)', '(Oxford)', '362881172'),
(19, 'Sound Wisdom', '', '615434951'),
(20, 'G&D Media', '', '558047523'),
(21, 'Penguin USA, Inc.', '', '502251785'),
(22, 'Independently Published', '', '495566875'),
(23, 'Tarcher', 'Taibei Xian Xindian Shi', '233533041'),
(24, 'lulu.com', '', '209472890'),
(25, 'TarcherPerigee', '', '239992010'),
(26, 'Zhongguo cheng shi chu ban she', '', '475934909'),
(27, 'Simon & Schuster, Incorporated', '', '294671455'),
(28, 'World s Work', '', '376610430'),
(29, 'www.bnpublishing.com', '', '950854908'),
(30, 'Simon & Schuster, Limited', '', '209425935'),
(31, 'McGraw', 'Hill Higher Education', '850173437'),
(32, 'Morgan James Publishing', '', '699434058'),
(33, 'Puffin', 'London', '843588341'),
(34, 'Puffin', '', '289496167'),
(35, 'Yale University Press', '', '628718589'),
(36, 'printed and published by John Stanfield', '', '842826783'),
(37, 'Michigan State University', '', '153089316'),
(38, 'Mladinski', '', '255326073'),
(39, 'Warner Bros. Publications', '', '898403045'),
(40, 'HarperCollins', '', '803678825'),
(41, 'Alfred Publishing', '', '755847264'),
(42, 'Hal Leonard Publishing Corporation', '', '444618696'),
(43, 'Eastman Kodak Company', '', '829133639'),
(44, 'Simon & Schuster (Paper)', '', '772106977'),
(45, 'Sterling', '', '915162972'),
(46, 'New Riders Press', '', '968188752'),
(47, 'Peachpit Press', '', '869134356'),
(48, 'Pogue Press/O Reilly', 'Farnham', '509211255'),
(49, 'Pearson Education, Limited', '', '786468098'),
(50, 'Pavilion Books', '', '501275824'),
(51, 'David & Charles', '', '840558809'),
(52, 'Carlton Books Sevenoaks', '', '269996215'),
(53, 'Octopus Books', '', '548204809'),
(54, 'Wiley & Sons, Incorporated, John', '', '989081875'),
(55, 'IDG Books Worldwide', '', '458432270'),
(56, 'Printed by R. Walker', '(Warswawa)', '682535862'),
(57, 'Barnes & Noble', '', '764983275'),
(58, 'Disney', 'Hyperion', '156727007'),
(59, 'Yuan Liu/Tsai Fong Books', '', '585164098'),
(60, 'Bell & Cockburn', 'New York', '113940041'),
(61, 'Vintage Books', 'London', '854792754'),
(62, 'Brilliance Audio', '', '898472939'),
(63, 'Atheneum', 'Sutton', '893011921'),
(64, 'Open Road Integrated Media, Inc.', '', '564504048'),
(65, 'HarperCollins Publishers', '', '758310423'),
(66, 'Longmans', 'Kraków, Poland', '539951829'),
(67, 'Bles Limited, Geoffrey', '', '485214102'),
(68, 'Andres Bello', '', '309906369'),
(69, 'Hesperus Press', 'New York', '284320049'),
(70, 'NuVision Publications', 'New York, USA', '294347846'),
(71, 'Dover Publications', 'New York', '505985211'),
(72, 'NuVision Publications', 'Leningrad', '208861567'),
(73, 'P. F. Collier & Son', '', '735159523'),
(74, 'Createspace Independent Publishing Platform', 'Cutchogue, NY', '854258255'),
(75, 'Audio Book Contractors', 'Fairfield, IA', '904744407'),
(76, 'Dover Publications', '', '885362164'),
(77, 'Smith, Elder & Co.', '', '552048105'),
(78, 'Award', 'Sevenoaks', '998168869'),
(79, 'FONTANA / Collins', 'Thorndike, Me', '784588547'),
(80, 'Harper/Collins', '', '147835608'),
(81, 'HarperCollins Publishers and Blackstone Audio', 'Great Britain', '283380375'),
(82, 'HarperCollins Publishers', 'Taibei Shi', '694085646'),
(83, 'Librairie des Champs', 'Elysees.', '394571009'),
(84, 'Librairie des Champs', 'Élysées', '874753515'),
(85, 'Warbler Classics', 'St Albans', '325997225'),
(86, 'Librairie des Champs', 'Elysées', '634752549'),
(87, 'KSA Publishing Consultants, Inc and Blackstone Publishing', '', '777405844'),
(88, 'Ksa Publishing Consultants Inc', '', '298658065'),
(89, 'Siren', 'BookStrand, Incorporated', '446949165'),
(90, 'Henry Holt & Company', '', '286941539'),
(91, 'Penguin Random House', '', '175853971'),
(92, '', 'Paris', '272043866'),
(93, 'Bloom Books', '', '206660212'),
(94, 'Knopf Doubleday Publishing Group', '', '169320215'),
(95, 'Random House Audio', 'Toronto, Ontario', '208421977'),
(96, 'Anchor Books', 'New York, USA', '204722459'),
(97, 'penguin books', '', '715558457'),
(98, 'Ebury Press', '', '554623935'),
(99, 'Dutton Juvenile', 'New York, New York', '691885158'),
(100, ' Dutton Penguin', 'New York', '883267685'),
(101, 'Glencoe/McGraw', 'Hill', '359012797'),
(102, 'Panther', 'Riga', '711241770'),
(103, 'Simon & Schuster Ltd', 'New York', '476265597'),
(104, 'Warner Bros. Entertainment', '', '820023993'),
(105, 'Books on Tape, Inc.', '', '272904805'),
(106, 'Penguin Group', 'Great Britain', '900586081'),
(107, 'Grand Central Publishing', '', '854494239'),
(108, 'HarperCollins', 'New York', '394472260'),
(109, 'Brand: John Blake', '', '469413987'),
(110, 'John Blake Publishing, Limited', '', '522988573'),
(111, 'Houghton Mifflin Harcourt Publishing Company', '', '508048684'),
(112, 'Addison', 'Wesley (C)', '699547062'),
(113, 'Wiley', '', '483182171'),
(114, 'For Dummies', '', '769805470'),
(115, 'John Wiley & Sons, Ltd.', '', '703166202'),
(116, 'Newnes', '', '435500068'),
(117, 'Addison', 'Wesley', '851898302'),
(118, 'Elsevier Science & Technology Books', '', '150743587'),
(119, 'Back Bay Books', '', '547596702'),
(120, 'John Wiley & Sons, Ltd.', 'New York', '948745501'),
(121, 'Mark Swing', '', '703283058'),
(122, 'Wiley & Sons, Limited, John', '', '842712209'),
(123, 'HarperAudio', '', '807870760'),
(124, 'POCKET JEUNESSE', 'Hamburg, Germany', '298723378'),
(125, 'Oetinger Friedrich GmbH', 'New York, USA', '398766503'),
(126, 'Círculo de Lectores, S.A.', 'Paris', '614428269'),
(127, 'Get Publishing', 'USA', '574042704'),
(128, 'Large Print Press', '', '485628000'),
(129, 'Phantom Press', 'Moskva', '233923747'),
(130, 'Pan Macmillan', '', '182419815'),
(131, 'Pan', '', '648810185'),
(132, 'Andrews McMeel Publishing', '', '782597012'),
(133, 'Andrews McMeel Publishing', 'Weinheim', '256699848'),
(134, 'Addison Wesley', '', '674730369'),
(135, 'D C Heath & Co', 'Lexington, Mass', '713106539'),
(136, 'Pearson Custom Publishing', '', '449189113'),
(137, 'HarperCollinsCollegePublishers', '', '215500847'),
(138, 'Harcourt Brace Jovanovich', '', '881191081'),
(139, 'Addison', 'Wesley', '681599834'),
(140, 'Pearson Education (US)', '', '906647819'),
(141, 'Wiley', 'New York', '858733479'),
(142, 'Princeton University Press', '', '319471006'),
(143, 'Allen Lane', 'New York, USA', '392145318'),
(144, 'Avalon Publishing', '', '801493001'),
(145, 'Mariner Books', '', '122503795'),
(146, 'New American Library', '', '475205707'),
(147, 'Viking', '', '671898225'),
(148, 'Bantam Doubleday Dell', 'New York', '231555263'),
(149, 'Penguin (Non', 'Classics)', '470736961'),
(150, 'Blackstone Audiobooks', 'New York, N.Y', '524932740'),
(151, 'Simon & Schuster', 'New York', '881495372'),
(152, 'Running Press Book Publishers', '', '826874395'),
(153, 'Random House Audio', 'London', '990370540'),
(154, 'Knopf', '', '543966886'),
(155, 'Penguin Books, Limited', '', '161025573'),
(156, 'Blackwell Pub.', '', '164137570'),
(157, 'Springer London, Limited', '', '167800457'),
(158, 'Picador', '', '659862918'),
(159, 'Geoplaneta', '', '203128315'),
(160, 'Prentice Hall', '', '131666218'),
(161, 'Pearson Education, Limited', 'San Francisco, CA', '413195678'),
(162, 'Benjamin', 'Cummings Publishing Company', '612267026'),
(163, 'Kessinger Publishing, LLC', '', '880907998'),
(164, 'Pennsylvania State University Press', '', '699211491'),
(165, 'Pearson Education, Limited', 'São Paulo', '506218305'),
(166, 'Butterworths', 'London', '473832098');

-- --------------------------------------------------------

--
-- Table structure for table `penulis`
--

DROP TABLE IF EXISTS `penulis`;
CREATE TABLE `penulis` (
  `ps_id` int(11) NOT NULL,
  `ps_name` varchar(100) NOT NULL,
  `ps_telephone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `penulis`
--

INSERT INTO `penulis` (`ps_id`, `ps_name`, `ps_telephone`) VALUES
(1, 'J. K. Rowling', '972384251'),
(2, 'Scott H. Young', '685305085'),
(3, 'James Clear', '720699315'),
(4, 'Robert T. Kiyosaki', '947354878'),
(5, 'Sharon L. Lechter', '932012940'),
(6, 'Stephen King', '893167613'),
(7, 'Bev Vincent', '311477932'),
(8, 'Michael Lewis', '322072517'),
(9, 'Arthur Conan Doyle', '658681780'),
(10, 'Richard Matheson', '210655471'),
(11, 'Ambrose Bierce', '294062083'),
(12, 'E. C. Tubb', '792562023'),
(13, 'Tom Bissell', '126205177'),
(14, 'Dan Simmons', '220005666'),
(15, 'Cody Goodfellow', '764293544'),
(16, 'John Varley', '205925637'),
(17, 'Joe Hill', '245975743'),
(18, 'David J. Schow', '399433058'),
(19, 'Ray Bradbury', '655651664'),
(20, 'Roald Dahl', '812443531'),
(21, 'Peter Tremayne', '294172662'),
(22, 'James L. Dickey', '535341247'),
(23, 'Michael E. Lewis', '703982068'),
(24, 'James Dickey', '593612650'),
(25, 'Thomas Carlisle Bissell', '182320019'),
(26, 'David G. Hartwell', '912318424'),
(27, 'John Collier', '824793412'),
(28, 'Montague Rhodes James', '631987913'),
(29, 'Lucy Clifford', '609626985'),
(30, 'Russell Kirk', '433758892'),
(31, 'H. P. Lovecraft', '268723165'),
(32, 'Shirley Jackson', '394163670'),
(33, 'Harlan Ellison', '492193468'),
(34, 'Nathaniel Hawthorne', '624749695'),
(35, 'Michael Shea', '880713382'),
(36, 'Edith Nesbit', '208563733'),
(37, 'Karl Edward Wagner', '936870475'),
(38, 'Robert Aickman', '208403722'),
(39, 'Fritz Leiber', '551595639'),
(40, 'Robert Bloch', '304283223'),
(41, 'Charles L. Grant', '905460755'),
(42, 'Manly Wade Wellman', '498200394'),
(43, 'Disch, Thomas M.', '809478334'),
(44, 'Theodore Sturgeon', '504072619'),
(45, 'Clive Barker', '648062004'),
(46, 'Edgar Allan Poe', '456475829'),
(47, 'Joseph Sheridan Le Fanu', '866023676'),
(48, 'Charlotte Perkins Gilman', '488242547'),
(49, 'William Faulkner', '254363340'),
(50, 'Robert Hichens', '491683858'),
(51, 'Joanna Russ', '410935735'),
(52, 'Dennis Etchison', '942169625'),
(53, 'D. H. Lawrence', '305594491'),
(54, 'Tanith Lee', '503054438'),
(55, 'Flannery O Connor', '860468758'),
(56, 'Ramsey Campbell', '944516076'),
(57, 'Henry James Jr.', '730360489'),
(58, 'Gene Wolfe', '708945016'),
(59, 'Charles Dickens', '592003133'),
(60, 'Joyce Carol Oates', '682255597'),
(61, 'Walter De la Mare', '256698836'),
(62, 'Ivan Turguenev', '252056320'),
(63, 'Robert W. Chambers', '590598832'),
(64, 'Oliver Onions', '197746748'),
(65, 'Fitz-James O Brien', '567641414'),
(66, 'Edith Wharton', '475741570'),
(67, 'Algernon Blackwood', '168872581'),
(68, 'Philip K. Dick', '774779069'),
(69, 'S. E. Hinton', '336745493'),
(70, 'The Zombies', '589045717'),
(71, 'Peter Straub', '783391026'),
(72, 'Napoleon Hill', '250592666'),
(73, 'Joseph Murphy', '160396370'),
(74, 'Dale Carnegie', '904019497'),
(75, 'Success', '396318932'),
(76, 'J. Oliver Crom', '612536682'),
(77, 'Michael A. Crom', '654221023'),
(78, 'Stephen E. Lucas', '611777562'),
(79, 'David Garfinkel', '112012118'),
(80, 'Jeff Kinney', '616223526'),
(81, 'Nikolaus Pevsner', '647697643'),
(82, 'Yorkshire. West-Riding.', '595152899'),
(83, 'Frank Lloyd Wright', '355772273'),
(84, 'Susan J. Bandes', '280926903'),
(85, 'Elizabeth Halsted', '835414898'),
(86, 'Tepfer', '894307233'),
(87, 'Senkevitch', '789280719'),
(88, 'Stanford', '850130062'),
(89, 'Richard Bradley', '295475654'),
(90, 'Dennis Alexander', '351101396'),
(91, 'Gayle Kowalchyk', '725554201'),
(92, 'E. Lancaster', '516300994'),
(93, 'Victoria McArthur', '112443386'),
(94, 'Martha Mier', '828067798'),
(95, 'T. Eveleth William', '953736855'),
(96, 'Eastman Kodak Company', '913836916'),
(97, 'Scott Kelby', '872097018'),
(98, 'David Pogue', '645733045'),
(99, 'Michael Busselle', '311571197'),
(100, 'Julien Busselle', '259875057'),
(101, 'Peter Cope', '385031297'),
(102, 'Julie Adair King', '960676512'),
(103, 'Robert Correll', '802796846'),
(104, 'William Shakespeare', '234680053'),
(105, 'Rick Riordan', '236005139'),
(106, 'Theodore Dreiser', '776925799'),
(107, 'Terry Brooks', '868373622'),
(108, 'Phil Gigante', '142816004'),
(109, 'R. A. Salvatore', '221759087'),
(110, 'Erika Lewis', '618354459'),
(111, 'C. S. Lewis', '501768599'),
(112, 'Derek Partridge', '968832418'),
(113, 'Enid Blyton', '517050559'),
(114, 'Celia Turvey', '744409536'),
(115, 'Agatha Christie', '104668197'),
(116, 'Hugh Fraser Sir', '664727530'),
(117, 'Grace Goodwin', '828090511'),
(118, 'Morgan Ashbury', '472155537'),
(119, 'Michael Hague', '793116110'),
(120, 'E. L. James', '641485666'),
(121, 'Kevin Kwan', '264298331'),
(122, 'John Green', '513562164'),
(123, 'Honoré de Balzac', '722544350'),
(124, 'Daniel Kahneman', '506654720'),
(125, 'Gordon Ramsay', '317336821'),
(126, 'Neil Simpson', '831794983'),
(127, 'Stafford Hildred', '984474418'),
(128, 'Tim Ewbank', '615307360'),
(129, 'Mark Bittman', '635273222'),
(130, 'Neal Goldstein', '307244836'),
(131, 'Neil Goldstein', '756794355'),
(132, 'Jeff Alger', '264746286'),
(133, 'D. Wilson', '396705290'),
(134, 'Tony Bove', '689843175'),
(135, 'Bruce Powel Douglass', '288796269'),
(136, 'David Harel', '558461088'),
(137, 'Nancy C. Muir', '990131326'),
(138, 'Joe Hutsko', '942171097'),
(139, 'Reeves Wiedeman', '342140531'),
(140, 'Thomas N. Bulkowski', '984882889'),
(141, 'Mark Swing', '138483230'),
(142, 'Eric, MBA Tyson', '403024564'),
(143, 'Eric Tyson', '161036702'),
(144, 'Ray Brown', '134402367'),
(145, 'Consumer Dummies', '407246217'),
(146, 'Suzanne Collins', '158904239'),
(147, 'Veronica Roth', '980062361'),
(148, 'George Orwell', '582197064'),
(149, 'Stephanie Calman', '328792235'),
(150, 'Matthew Inman', '441441630'),
(151, 'E. John Hornsby', '397024656'),
(152, 'Ron Larson', '687768401'),
(153, 'Margaret L. Lial', '545294284'),
(154, 'Thomas W. Hungerford', '197873030'),
(155, 'Charles David Miller', '979943580'),
(156, 'Charles P. McKeague', '275857942'),
(157, 'Richard Blum', '934063486'),
(158, 'Christine Bresnahan', '503768874'),
(159, 'Dee-Ann LeBlanc', '118290799'),
(160, 'Melanie Hoag', '793351963'),
(161, 'Evan Blomquist', '478630352'),
(162, 'Steven H. Strogatz', '200207510'),
(163, 'Beverly West', '773415327'),
(164, 'Rombauer', '315119344'),
(165, 'Irma S. Rombauer', '935624991'),
(166, 'Marion Rombauer Becker', '304657581'),
(167, 'Ethan Becker', '584591738'),
(168, 'John Becker', '807524625'),
(169, 'Megan Scott', '727143162'),
(170, 'Charles Seife', '932020441'),
(171, 'Alfred Bester', '301965017'),
(172, 'Lucy Hawking', '105470186'),
(173, 'Stephen Hawking', '379342570'),
(174, 'Brian Greene', '438915045'),
(175, 'Robert W. Proctor', '762423827'),
(176, 'Lennart Bengtsson', '832308512'),
(177, 'Roger-Maurice Bonnet', '420392786'),
(178, 'David Grinspoon', '216173517'),
(179, 'Symeon Koumoutsaris', '685387274'),
(180, 'Sebastien Lebonnois', '156243298'),
(181, 'Dmitri Titov', '809686582'),
(182, 'Alan Stern', '353259599'),
(183, 'Olivier Cirendini', '977413812'),
(184, 'Lawrence G. Campbell', '969160634'),
(185, 'Neil Alexander Campbell', '772539201'),
(186, 'Jane B. Reece', '949641925'),
(187, 'Eric J. Simon', '621073802'),
(188, 'Judith Giles Morgan', '543247174'),
(189, 'A. E. W. (Alfred Edward Woodley) Mason', '227986195'),
(190, 'Theodore L. Brown', '349965906'),
(191, 'H. Eugene Lemay', '809927153'),
(192, 'Bruce E. Bursten', '695840518'),
(193, 'Catherine Murphy', '316625303'),
(194, 'Patrick Woodward', '656763768'),
(195, 'Thomas Engel', '883910827'),
(196, 'Johann Gasteiger', '298479869'),
(197, 'Philip Reid', '388446120'),
(198, 'Robert A. Alberty', '544250747'),
(199, 'Robert J. Sibley', '675927520'),
(200, 'Farrington Daniels', '326994985'),
(201, 'David A. Chin', '619176470');

-- --------------------------------------------------------

--
-- Table structure for table `rak_buku`
--

DROP TABLE IF EXISTS `rak_buku`;
CREATE TABLE `rak_buku` (
  `rb_id` int(11) NOT NULL,
  `rb_height` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rak_buku`
--

INSERT INTO `rak_buku` (`rb_id`, `rb_height`) VALUES
(1, 3),
(2, 6),
(3, 4),
(4, 8),
(5, 10),
(6, 4),
(7, 4),
(8, 10);

-- --------------------------------------------------------

--
-- Table structure for table `rating`
--

DROP TABLE IF EXISTS `rating`;
CREATE TABLE `rating` (
  `ra_id` int(11) NOT NULL,
  `ra_value` int(11) NOT NULL,
  `ra_bu_id` int(11) NOT NULL,
  `ra_me_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`bu_id`),
  ADD KEY `bu_rb_id` (`bu_rb_id`),
  ADD KEY `bu_pt_id` (`bu_pt_id`);

--
-- Indexes for table `buku_penulis`
--
ALTER TABLE `buku_penulis`
  ADD PRIMARY KEY (`bp_id`),
  ADD KEY `bp_bu_id` (`bp_bu_id`),
  ADD KEY `bp_ps_id` (`bp_ps_id`);

--
-- Indexes for table `denda`
--
ALTER TABLE `denda`
  ADD PRIMARY KEY (`de_id`);

--
-- Indexes for table `detaildenda`
--
ALTER TABLE `detaildenda`
  ADD PRIMARY KEY (`dd_id`),
  ADD KEY `dd_hp_id` (`dd_hp_id`),
  ADD KEY `dd_de_id` (`dd_de_id`);

--
-- Indexes for table `dpinjam`
--
ALTER TABLE `dpinjam`
  ADD PRIMARY KEY (`dp_id`),
  ADD KEY `dp_bu_id` (`dp_bu_id`),
  ADD KEY `dp_hp_id` (`dp_hp_id`);

--
-- Indexes for table `genre`
--
ALTER TABLE `genre`
  ADD PRIMARY KEY (`ge_id`);

--
-- Indexes for table `genre_buku`
--
ALTER TABLE `genre_buku`
  ADD PRIMARY KEY (`gb_id`),
  ADD KEY `gb_bu_id` (`gb_bu_id`),
  ADD KEY `gb_ge_id` (`gb_ge_id`);

--
-- Indexes for table `hpinjam`
--
ALTER TABLE `hpinjam`
  ADD PRIMARY KEY (`hp_id`),
  ADD KEY `hp_me_id` (`hp_me_id`),
  ADD KEY `hp_pe_id` (`hp_pe_id`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`me_id`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`pe_id`);

--
-- Indexes for table `penerbit`
--
ALTER TABLE `penerbit`
  ADD PRIMARY KEY (`pt_id`);

--
-- Indexes for table `penulis`
--
ALTER TABLE `penulis`
  ADD PRIMARY KEY (`ps_id`);

--
-- Indexes for table `rak_buku`
--
ALTER TABLE `rak_buku`
  ADD PRIMARY KEY (`rb_id`);

--
-- Indexes for table `rating`
--
ALTER TABLE `rating`
  ADD PRIMARY KEY (`ra_id`),
  ADD KEY `ra_bu_id` (`ra_bu_id`),
  ADD KEY `ra_me_id` (`ra_me_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `buku`
--
ALTER TABLE `buku`
  MODIFY `bu_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=195;

--
-- AUTO_INCREMENT for table `buku_penulis`
--
ALTER TABLE `buku_penulis`
  MODIFY `bp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=329;

--
-- AUTO_INCREMENT for table `denda`
--
ALTER TABLE `denda`
  MODIFY `de_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `detaildenda`
--
ALTER TABLE `detaildenda`
  MODIFY `dd_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `dpinjam`
--
ALTER TABLE `dpinjam`
  MODIFY `dp_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `genre`
--
ALTER TABLE `genre`
  MODIFY `ge_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `genre_buku`
--
ALTER TABLE `genre_buku`
  MODIFY `gb_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=270;

--
-- AUTO_INCREMENT for table `hpinjam`
--
ALTER TABLE `hpinjam`
  MODIFY `hp_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `me_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `pegawai`
--
ALTER TABLE `pegawai`
  MODIFY `pe_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `penerbit`
--
ALTER TABLE `penerbit`
  MODIFY `pt_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=167;

--
-- AUTO_INCREMENT for table `penulis`
--
ALTER TABLE `penulis`
  MODIFY `ps_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=202;

--
-- AUTO_INCREMENT for table `rak_buku`
--
ALTER TABLE `rak_buku`
  MODIFY `rb_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `rating`
--
ALTER TABLE `rating`
  MODIFY `ra_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `buku`
--
ALTER TABLE `buku`
  ADD CONSTRAINT `buku_ibfk_2` FOREIGN KEY (`bu_rb_id`) REFERENCES `rak_buku` (`rb_id`),
  ADD CONSTRAINT `buku_ibfk_3` FOREIGN KEY (`bu_pt_id`) REFERENCES `penerbit` (`pt_id`);

--
-- Constraints for table `buku_penulis`
--
ALTER TABLE `buku_penulis`
  ADD CONSTRAINT `buku_penulis_ibfk_1` FOREIGN KEY (`bp_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `buku_penulis_ibfk_2` FOREIGN KEY (`bp_ps_id`) REFERENCES `penulis` (`ps_id`);

--
-- Constraints for table `detaildenda`
--
ALTER TABLE `detaildenda`
  ADD CONSTRAINT `detaildenda_ibfk_1` FOREIGN KEY (`dd_hp_id`) REFERENCES `hpinjam` (`hp_id`),
  ADD CONSTRAINT `detaildenda_ibfk_2` FOREIGN KEY (`dd_de_id`) REFERENCES `denda` (`de_id`);

--
-- Constraints for table `dpinjam`
--
ALTER TABLE `dpinjam`
  ADD CONSTRAINT `dpinjam_ibfk_1` FOREIGN KEY (`dp_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `dpinjam_ibfk_2` FOREIGN KEY (`dp_hp_id`) REFERENCES `hpinjam` (`hp_id`);

--
-- Constraints for table `genre_buku`
--
ALTER TABLE `genre_buku`
  ADD CONSTRAINT `genre_buku_ibfk_1` FOREIGN KEY (`gb_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `genre_buku_ibfk_2` FOREIGN KEY (`gb_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `genre_buku_ibfk_3` FOREIGN KEY (`gb_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `genre_buku_ibfk_4` FOREIGN KEY (`gb_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `genre_buku_ibfk_5` FOREIGN KEY (`gb_ge_id`) REFERENCES `genre` (`ge_id`);

--
-- Constraints for table `hpinjam`
--
ALTER TABLE `hpinjam`
  ADD CONSTRAINT `hpinjam_ibfk_1` FOREIGN KEY (`hp_me_id`) REFERENCES `member` (`me_id`),
  ADD CONSTRAINT `hpinjam_ibfk_2` FOREIGN KEY (`hp_pe_id`) REFERENCES `pegawai` (`pe_id`),
  ADD CONSTRAINT `hpinjam_ibfk_3` FOREIGN KEY (`hp_me_id`) REFERENCES `member` (`me_id`),
  ADD CONSTRAINT `hpinjam_ibfk_4` FOREIGN KEY (`hp_pe_id`) REFERENCES `pegawai` (`pe_id`),
  ADD CONSTRAINT `hpinjam_ibfk_5` FOREIGN KEY (`hp_me_id`) REFERENCES `member` (`me_id`),
  ADD CONSTRAINT `hpinjam_ibfk_6` FOREIGN KEY (`hp_pe_id`) REFERENCES `pegawai` (`pe_id`),
  ADD CONSTRAINT `hpinjam_ibfk_7` FOREIGN KEY (`hp_me_id`) REFERENCES `member` (`me_id`),
  ADD CONSTRAINT `hpinjam_ibfk_8` FOREIGN KEY (`hp_pe_id`) REFERENCES `pegawai` (`pe_id`);

--
-- Constraints for table `rating`
--
ALTER TABLE `rating`
  ADD CONSTRAINT `rating_ibfk_1` FOREIGN KEY (`ra_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `rating_ibfk_2` FOREIGN KEY (`ra_me_id`) REFERENCES `member` (`me_id`),
  ADD CONSTRAINT `rating_ibfk_3` FOREIGN KEY (`ra_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `rating_ibfk_4` FOREIGN KEY (`ra_me_id`) REFERENCES `member` (`me_id`),
  ADD CONSTRAINT `rating_ibfk_5` FOREIGN KEY (`ra_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `rating_ibfk_6` FOREIGN KEY (`ra_me_id`) REFERENCES `member` (`me_id`),
  ADD CONSTRAINT `rating_ibfk_7` FOREIGN KEY (`ra_bu_id`) REFERENCES `buku` (`bu_id`),
  ADD CONSTRAINT `rating_ibfk_8` FOREIGN KEY (`ra_me_id`) REFERENCES `member` (`me_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
