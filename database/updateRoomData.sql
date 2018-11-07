USE [Nursery]
GO
/****** Object:  StoredProcedure [dbo].[updateRoomtData]    Script Date: 11/7/2018 1:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[updateRoomData]
@roomID int,
@roomNumber int,
@roomStaffID int
as
begin
update Room set roomNumber = @roomNumber , roomStaffID = @roomStaffID
where roomID = @roomID
