import sqlite3
import os



class Database():
    path = ""
    def __init__(self):
        #cur_dir = os.path.dirname(os.path.realpath(__file__))
        #self.cur_dir = cur_dir + "\\command.db"
        pass


    @classmethod
    def commit(cls):
        cls.connection.commit()


    @classmethod
    def close(cls):
        cls.connection.close()


    @classmethod
    def create(cls):       
            cls.connection = sqlite3.connect(cls.path)
            print("file created")

            query = cls.connection.cursor()
            
            query.execute('''CREATE TABLE commands (
                ID integer PRIMARY KEY AUTOINCREMENT,
                Real_ID integer NOT NULL,
                FileName text NOT NULL,
                Section Not Null,
                Path text Not Null,
            )''')

            query.execute('''CREATE TABLE scripts (
            ID integer PRIMARY KEY AUTOINCREMENT,
            ScriptName text NOT NULL,
            ExecuteName text NOT NULL UNIQUE,
            ScriptStructure text NOT NULL
            )''')

            cls.commit()
            cls.close()


    @classmethod
    def get_string(cls):
        if cls.path == "":
            path = os.path.dirname(os.path.realpath(__file__))
            cls.path = path + "\\command.db"

        if os.path.exists(cls.path) == False:
            cls.create()
        else:
            cls.connection = sqlite3.connect(cls.path)

        print("Done")
        return cls.connection


    @classmethod
    def set_path(cls, path):
        cls.path = path










