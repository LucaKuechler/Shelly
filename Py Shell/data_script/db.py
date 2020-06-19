import sqlite3
import os



class Database():
    def __init__(self):
        #cur_dir = os.path.dirname(os.path.realpath(__file__))
        #self.cur_dir = cur_dir + "\\command.db"
        pass

    def commit(self):
        self.connection.commit()


    def close(self):
        self.connection.close()


    def create(self):       
            self.connection = sqlite3.connect(self.path)
            print("file created")

            query = connection.cursor()
            
            query.execute('''CREATE TABLE commands (
                ID integer PRIMARY KEY AUTOINCREMENT,
                Real_ID integer NOT NULL,
                FileName text NOT NULL,
                Section Not Null
            )''')

            query.execute('''CREATE TABLE scripts (
            ID integer PRIMARY KEY AUTOINCREMENT,
            ScriptName text NOT NULL,
            ExecuteName text NOT NULL UNIQUE,
            ScriptStructure text NOT NULL
            )''')

            self.commit()
            self.close()


    def get_string(self):
        print(self.path)
        if os.path.exists(self.path) == False:
            self.create()
        else:
            self.connection = sqlite3.connect(self.path)

        print("Done")
        return self.connection


    def set_path(self, path):
        print(path)
        self.path = path
        print(self.path)
        self.get_string()












