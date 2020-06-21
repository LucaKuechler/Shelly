#import db_fastScript
import os


class db_command_list():
    def __init__(self):
        self.section_name = []
        self.command_files = []
        self.path = os.path.dirname(os.path.realpath(__file__))
        control_path = "Functions"
        home_path = "data_script"

        #started from cur path
        if control_path not in self.path:
            if home_path in self.path: 
                self.path = os.path.abspath(self.path + "\\..\\") 

            self.path += "\\Functions"
        

    @staticmethod
    def get_files(path):
        ''' return only the files '''
        items = os.listdir(path)
        files = []
        for i in items:
            if "." in i:
                files.append(i)
        return files


    @staticmethod
    def create_section_attributes(path):
        li = []
        test = ""
        path_li = path.split("\\")
        counter = len(path_li) - 1
        li.append(path_li[counter])

        cur_index = path_li.index("Functions")
        for d in path_li range(cur_index,len(path), 1)):
            test += ">" + d


    @staticmethod
    def get_sections(path):
        ''' get one path and check for child folders '''

        files = db_command_list.get_files(path)
        class_file = []
        class_path_list = db_command_list.create_section_attributes(path)

        for f in files:
            class_file.append(f)
            class_file.append(path)
        return files

        ''' Command-Name | Path | Section-Name | File-List '''


    def loop_sections(self):
        path = self.path
        main_folders = [x[0] for x in os.walk(path)] 
        main_folders.pop(0)
        items = []

        for p in main_folders:
            asd = db_command_list.get_sections(p)
            items += asd 
        print(items)


    def set_path(self, path):
        self.path = path
        #get_files()

    

    #all files = commands[1.File[Name | Section | Path]]
    



class db_script_list():
    def __init__(self):
        pass