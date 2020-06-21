import sqlite3
import db

class DB_Commands():
    def __init__(self):
        self.connection = db.Database().get_string()
        self.query = self.connection.cursor()


    def update_commands(self):
        pass
        
        
    def test(self):
        print(db.Database().get_string())

