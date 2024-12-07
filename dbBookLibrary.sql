SELECT TOP (1000) [PageID]
      ,[PageName]
      ,[Contents]
      ,[Thumb]
      ,[Published]
      ,[Title]
      ,[Alias]
      ,[CreateDate]
      ,[Ordering]
  FROM [dbBookLibrary].[dbo].[Pages]

INSERT INTO [dbBookLibrary].[dbo].[Pages]
    ([PageID], [PageName], [Contents], [Thumb], [Published], [Title], [Alias], [CreateDate], [Ordering])
VALUES
    (1, -- PageID (giá trị tùy bạn đặt, miễn không trùng với các giá trị hiện có)
     N'Hướng dẫn mua hàng',
     N'Nội dung chi tiết về cách mua hàng.',
     N'/images/guide.jpg',
     1,
     N'Hướng dẫn mua hàng',
     N'huong-dan-mua-hang',
     GETDATE(),
     1);

	 DELETE FROM [dbBookLibrary].[dbo].[Pages];

	 SELECT 
    [PageID],
    [PageName],
    [Contents],
    [Thumb],
    CASE 
        WHEN [Published] = 1 THEN N'Public'
        ELSE N'private'
    END AS TrangThai,
    [Title],
    [Alias],
    [CreateDate],
    [Ordering]
FROM 
    [dbBookLibrary].[dbo].[Pages];
