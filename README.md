# BankDbHelper
看过了许多风景，有时候sql一把梭你可能需要这样一个轮子。。。

轮子基于Net standard2.1 + NetFramework4.0，nuget还原即用

BankSqlHelper bankSqlHelper = new BankSqlHelper(new DbInfo
                {
                    ServerName = "localhost",
                    DataBaseName = "fjzy",
                    DbType = DBTypeEnum.Oracle,
                    Password = "0000",
                    UserName = "sysdba",
                    Port = "1521"
                });

目前支持sqlserver、Oracle、Mysql、Sqlite

虽然用过了很多dbhelper,相信这个会给你别样的体验
