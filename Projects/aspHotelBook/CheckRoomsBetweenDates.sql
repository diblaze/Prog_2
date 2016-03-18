DECLARE @start DATETIME;
set @start = '2016-03-15';
DECLARE @end DATETIME;
set @end= '2016-03-22';

            Select * from Rooms where Adults >= 2 AND Children >= 2 AND
			Rooms.RoomNr not in 
			(select RoomNr from Bookings where
			(CheckedIn between @start and @end ) OR
			(CheckingOut between @start and @end) OR
			(@start between CheckedIn and CheckingOut) OR
			(@end between CheckedIn and CheckingOut) OR
			(@start <= CheckedIn and @end >= CheckingOut) OR
			(@start <= @end))

			