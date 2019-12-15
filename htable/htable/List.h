
#pragma once

const int sizeOfWord = 20;

// ������� ������
struct ListElement;

// ������ 
struct List;

// ���-�������
struct HashTable;

// ������� ������
List* createList();

// �������� ������ �� �������
bool empty(List* head);

// �������� ������� � ������
void addToList(List* list, char word[], int amount);

// ������� ������
void outputList(List* list);

// �������� �������� �� �������������� ������
bool containsInList(List* list, char word[]);

// ������� ������
void deleteList(List* list);

// ��������� �������� �� ������ ������ ���-������� � ����� ���-�������
void pushToNewTableFromOldList(List* oldList, HashTable* newTable);

// �������� ������ ������
int getSizeOfList(List* list);

// �������� �������� �� �������������� ������
// ���� �����������, �� �������� ����� �� �������
bool containsAndAddInList(List* list, char word[]);