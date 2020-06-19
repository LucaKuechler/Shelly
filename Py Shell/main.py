import cmd
import shell
import time
import os
from data_script import db
#import CommandList
#import ScriptList

#Main
class Program(shell.Shell):

    ''' system function '''

    def main(self, list_input):
        path = os.path.dirname(os.path.realpath(__file__))
        path = path + "\\data_script\\command.db"
        db.Database().set_path(path)
        print(db.Database().get_string()) 


#region Main Loop
if __name__ == '__main__':
    while True:
        Object = Program()
        status = Object.call_shell()
        list_input = Object.get_list()
        list_struc = Object.get_struc()

        t0 = time.time()
        if status == False:
            break
        else:
            Program().main(list_input)
            t1 = time.time()
            total = t1 - t0
            print(f"{total} secconds")

#endregion


    