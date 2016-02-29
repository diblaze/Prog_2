DECLARE @startBook datetime;
DECLARE @endBook datetime;
DECLARE @manufacture nvarchar(50);
DECLARE @model nvarchar(50);
DECLARE @type nvarchar(50);
SET @startBook = CONVERT(datetime, '2016-02-13');
SET @endBook = CONVERT(datetime, '2016-03-14');
SET @manufacture = 'Volvo';
SET @model = 'V60 Polestar';
SET @type = 'Car';


SELECT * FROM Vehicles WHERE Vehicles.RegNo NOT IN
     (
	 SELECT RegNo from Bookings where 
	 (StartBooking between @startBook and @endBook) or
	 (EndBooking between @startBook and @endBook) or
	 (@startBook between StartBooking and EndBooking) or 
	 (@endBook between StartBooking and EndBooking) or
	 (@startBook < StartBooking and @endBook > EndBooking) or
	 (@startBook < @endBook)
	 )
	 and [Type]=@type
	 