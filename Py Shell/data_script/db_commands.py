import sqlite3
from data_script import  db
import os
from data_script import  data_list

class DB_Commands():
    def __init__(self):
        self.connection = db.Database().get_string()
        self.query = self.connection.cursor()
        self.items = data_list.db_command_list().global_items
     


    def check_database(self, item):
        ''' Search a element name in the database and store its data.
            Then compare the data to the given item and return the status:
            #row data is same = 2
            #row data is there but different = 1
            #row data doesnt exist = 0
        '''

        try:
            self.query = self.connection.cursor()
            ID = item[0]

            self.query.execute("SELECT * FROM commands WHERE FileName=?", (ID,))
            row_data = self.query.fetchall()
            self.query.close()
            
            row_data = row_data[0]
            row_data = row_data[2:5]
            compare = []

            for x in range(0, len(row_data),1):
                if row_data[x] == item[x]:
                    compare.append(True)
                else:
                    compare.append(False)
            
            print(compare)
            for comp in compare:
                if comp == False:
                    return 1

            return 2
        except:
            return 0
            


    def insert_commands(self, item):
        self.query = self.connection.cursor()
        ID = None
        Real_ID = 1
        FileName = item[0]
        Section = item[1]
        Path = item[2]

        sqlite_select_query = '''INSERT INTO commands
        (ID, Real_ID, FileName, Section, Path)
        VALUES
        (?,?,?,?,?)
        '''
        data_tuple = (ID, Real_ID, FileName, Section, Path)

        self.query.execute(sqlite_select_query,data_tuple)
        self.connection.commit()
        self.query.close()
        print("input done")


        
    def update_commands(self, item):
        self.query = self.connection.cursor()

        FileName = item[0] 
        Section = item[1] 
        Path = item[2] 

        sqlite_select_query = '''UPDATE commands set Section = ? where FileName = ?'''
        data_tuple = (Section, FileName)
        print(Section)
        self.query.execute(sqlite_select_query, data_tuple)
        self.connection.commit()
        self.query.close()
        print("updated")

    def editing_loop(self):

        for item in self.items:
            value = self.check_database(item)
            print(value)
            if value == 2:
                pass
            elif value == 1:
                self.update_commands(item)
            else:
                self.insert_commands(item)
            
                
