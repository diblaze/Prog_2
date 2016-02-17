DECLARE @startBook datetime;
DECLARE @endBook datetime;
SET @startBook = CONVERT(datetime, '2016-02-12');
SET @endBook = CONVERT(datetime, '2016-03-20');

SELECT * FROM Vehicles WHERE NOT EXISTS
     (SELECT * FROM Bookings 
      WHERE RegNo = Vehicles.RegNo AND @startBook < @endBook AND StartBooking < @endBook AND EndBooking > @startBook)