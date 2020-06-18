import cmd
import shell
#import commandList

#Main
class Program(shell.Shell):

    ''' system function '''

    def main(self, list_input):
        print(list_input)


    def run_command(self):
        pass


if __name__ == '__main__':
    while True:
        Object = Program()
        status = Object.call_shell()
        list_input = Object.get_list()
        list_struc = Object.get_struc()

        if status == False:
            break
        else:
            Program().main(list_input)



    