import java.util.Scanner;

class Node {
    int data;
    Node next;

    Node(int data) {
        this.data = data;
        this.next = null;
    }
}

class SinglyLinkedList {
    private Node head;

    // Insert at the beginning
    public void insertAtBeginning(int data) {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
        System.out.println(data + " inserted at the beginning.");
    }

    // Delete from the beginning
    public void deleteFromBeginning() {
        if (head == null) {
            System.out.println("List is empty. Nothing to delete.");
            return;
        }
        System.out.println(head.data + " deleted from the beginning.");
        head = head.next;
    }

    // Display all elements
    public void display() {
        if (head == null) {
            System.out.println("List is empty.");
            return;
        }
        System.out.print("Linked List: ");
        Node current = head;
        while (current != null) {
            System.out.print(current.data + " -> ");
            current = current.next;
        }
        System.out.println("NULL");
    }

    // Search an element
    public void search(int key) {
        Node current = head;
        int position = 1;
        while (current != null) {
            if (current.data == key) {
                System.out.println(key + " found at position " + position + ".");
                return;
            }
            current = current.next;
            position++;
        }
        System.out.println(key + " not found in the list.");
    }

    // Delete a specific element by value
    public void deleteElement(int key) {
        if (head == null) {
            System.out.println("List is empty. Nothing to delete.");
            return;
        }

        if (head.data == key) {
            head = head.next;
            System.out.println(key + " deleted from the list.");
            return;
        }

        Node current = head;
        Node prev = null;

        while (current != null && current.data != key) {
            prev = current;
            current = current.next;
        }

        if (current == null) {
            System.out.println(key + " not found in the list.");
            return;
        }

        prev.next = current.next;
        System.out.println(key + " deleted from the list.");
    }
}

public class LinkedListApp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        SinglyLinkedList list = new SinglyLinkedList();

        int choice;
        do {
            System.out.println("\n--- Linked List Menu ---");
            System.out.println("0. Terminate the Program");
            System.out.println("1. Insert an Element (Beginning)");
            System.out.println("2. Delete an Element (Beginning)");
            System.out.println("3. Display All Elements");
            System.out.println("4. Search an Element");
            System.out.println("5. Delete an Element");
            System.out.print("Enter your choice: ");
            choice = scanner.nextInt();

            switch (choice) {
                case 0:
                    System.out.println("Program terminated.");
                    break;
                case 1:
                    System.out.print("Enter element to insert: ");
                    int insertData = scanner.nextInt();
                    list.insertAtBeginning(insertData);
                    break;
                case 2:
                    list.deleteFromBeginning();
                    break;
                case 3:
                    list.display();
                    break;
                case 4:
                    System.out.print("Enter element to search: ");
                    int searchData = scanner.nextInt();
                    list.search(searchData);
                    break;
                case 5:
                    System.out.print("Enter element to delete: ");
                    int deleteData = scanner.nextInt();
                    list.deleteElement(deleteData);
                    break;
                default:
                    System.out.println("Invalid choice! Try again.");
            }

        } while (choice != 0);

        scanner.close();
    }
}
