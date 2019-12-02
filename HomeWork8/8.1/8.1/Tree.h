#pragma once

// ����� ����� � �������
const int sizeOfWord = 50;

// ������ 
struct Tree;

// ������� ������
struct TreeElement;

// ������� ������
Tree* create();

// �������� ������ �� �������
bool empty(Tree* tree);

// ���������� ������ �������� � ������
void push(Tree* tree, int key, char word[]);

// �������� ������ �� ������� �����
bool checkKeyInTree(Tree* tree, int key);

// �������� ������ �� ������� �����
char* checkWordInTree(Tree* tree, int key);

// ����� ����������� ��������� �������� �������� � ������
void checkElementForDelete(Tree* tree, int key);

// �������� ������
void deleteTree(Tree* tree);