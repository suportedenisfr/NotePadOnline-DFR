
Author: Denis Fabiano Ribeiro
Location: Brazil
Contact: suporte_denisfr@yahoo.com.br

Objective: Create a simple notepad to share text on the web.
Technologies involved: .Net 4.0, WCF, Entity Framework, JSON, JQuery and HTML.
Database: Sql Server Express.

Steps:
1) Install the backup file or database scripts.
2) Register the WCF Server on IIS.
3) Register the virtual directory for the WebClient folder in IIS.
4)Adjust Paths:
- Database Scripts: Set the path to the files: BlockNotes.mdf and BlockNotes_log.ldf
- If you prefer, instead of using scripts, restore the database backup.
- WebClient: lib.js -> Fix urls that reference the WCF service
- Project Server: web.config -> Set value of tag 'baseAddress ='


