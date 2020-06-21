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
    def check_folder(cur_folder_items):
        ''' Checks if current folder contains a child folder '''
        counter = 0

        for i in cur_folder_items:
            if "." not in i:
                counter += 1
        return counter
        

    @staticmethod
    def get_items(path):
        return os.listdir(path)


    def get_sections(self):
        path = self.path
        main_folders = [x[0] for x in os.walk(path)] 
        main_folders.pop(0)

        counter = 0
        for p in main_folders:
            items = db_command_list.get_items(p)
            value = db_command_list.check_folder(items)
            if not value > 0:
                self.command_files += items
            else:
                print(value)
            
        print(self.command_files)

        #sub_sub_folder = []
        # counter = 0

        # for p in sub_folders: 
        #     sub_sub_folder.append(os.listdir(p)) #child folder with files
        #     if sub_sub_folder[counter] != []:
        #         for li in sub_sub_folder[counter]: # all sub files
        #             if "." not in li: #if folder do ...
        #                 print("folder")
        #     counter += 1

        #     #for pp in sub_sub_folder:

        ''' Command-Name | Path | Section-Name | File-List '''


    def set_path(self, path):
        self.path = path
        #get_files()

    


    #all files = commands[1.File[Name | Section | Path]]
    



class db_script_list():
    def __init__(self):
        pass