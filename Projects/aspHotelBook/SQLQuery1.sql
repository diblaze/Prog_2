DECLARE @start datetime2;
DECLARE @end datetime2;

SET @start = '2016-04-16';
SET @end = '2016-04-18';

SELECT * FROM Rooms WHERE Adults >= 1 AND Children >= 0 AND
Rooms.RoomNr NOT IN (SELECT RoomNr FROM Bookings WHERE 
(CheckedIn BETWEEN @start and @end) OR (CheckingOut BETWEEN @start and @end) 
OR (@start BETWEEN CheckedIn and CheckingOut) OR (@end BETWEEN CheckedIn and CheckingOut)
OR (@start <= CheckedIn AND @end >= CheckingOut) OR
(@start >= @end))