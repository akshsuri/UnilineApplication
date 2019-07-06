
BEGIN TRY
	BEGIN TRAN T1
		INSERT INTO dbo.CAPACITY_PROVIDER VALUES('2','Mardock Marlene','Paris','+385 52 565362','marlene1@pu.t-com.hr','2946/2019')
		INSERT INTO dbo.CAPACITY_PROVIDER VALUES('3','Queens Marinele','Amsterdam','+385 52 852372','','2905/2019')
		INSERT INTO dbo.CAPACITY_PROVIDER VALUES('4','Lukman Perles','Nashik','','lukman80@yahoo.com','3253/2019')
		INSERT INTO dbo.CAPACITY_PROVIDER VALUES('5','Jack Johnes','Rovinj','','milmatjohnes@hotmail.com','3522/2019')
		INSERT INTO dbo.CAPACITY_PROVIDER VALUES('6','Joan Ofarc','Pula','+385 52 232538','ivesel123@gmail.com','3107/2019')
	COMMIT TRAN T1
END TRY
BEGIN CATCH
	ROLLBACK TRAN T1
END CATCH

BEGIN TRY
	BEGIN TRAN T2
		INSERT INTO dbo.BOOKING VALUES('2','QUEEN - Rabac','3','2019-06-27','2019-07-04','true','396.03','EUR','')
		INSERT INTO dbo.BOOKING VALUES('3','MARKO - Rome','2','2019-07-11','2019-07-24','true','1138.54','EUR','')
		INSERT INTO dbo.BOOKING VALUES('4','MARKO - Amsterdam','2','2019-07-11','2019-07-24','false','1088.68','EUR','')
		INSERT INTO dbo.BOOKING VALUES('5','IVANKA - Perth','6','2019-08-24','2019-08-31','true','327.8','EUR','')
		INSERT INTO dbo.BOOKING VALUES('6','MARKO - Berlin','2','2019-08-08','2019-08-15','true','572.34','EUR','object change')
		INSERT INTO dbo.BOOKING VALUES('8','IVANKA - New York','6','2019-09-12','2019-09-13','true','85.05','EUR','peter72@gmail.com')
		INSERT INTO dbo.BOOKING VALUES('9','MARKO - Los Angeles','2','2019-08-15','2019-08-22','false','3522.956','HRK','')
		INSERT INTO dbo.BOOKING VALUES('11','KRALJ - Prague','3','2019-08-01','2019-08-08','true','733.93','EUR','')
		INSERT INTO dbo.BOOKING VALUES('12','KRALJ - Prague','3','2019-08-15','2019-08-22','false','368.07','EUR','')
		INSERT INTO dbo.BOOKING VALUES('13','MILAN - Athene','5','2019-08-22','2019-08-29','false','2229.338','HRK','')
		INSERT INTO dbo.BOOKING VALUES('14','BIBA - Madrid','4','2019-07-11','2019-07-18','true','536.01','EUR','guest accepted the offer')
		INSERT INTO dbo.BOOKING VALUES('15','IVANKA - Kolkata','6','2019-06-01','2019-06-02','true','65.46','EUR','')
		INSERT INTO dbo.BOOKING VALUES('16','MARKO - Sidney','2','2019-08-22','2019-08-29','true','332.65','EUR','')
	COMMIT TRAN T2
END TRY
BEGIN CATCH
	ROLLBACK TRAN T2
END CATCH
