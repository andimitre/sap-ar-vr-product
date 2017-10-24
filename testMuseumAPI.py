import json
import requests

century = input('Which century are you looking for works from: ')
queryCentury = '&f.dating.period=' + century
url = 'https://www.rijksmuseum.nl/api/en/collection?key=YOUR_API_KEY_HERE&format=json' + queryCentury
response = requests.get(url).json()
#print(response)

artObjects = response['artObjects']
#print(artObjects)

listOfUrls = []
for artObject in artObjects:
    listOfUrls.append(artObject['webImage']['url'])
#print(listOfUrls)

for url in listOfUrls:
    response = requests.get(url)
    fileName = 'image' + str(listOfUrls.index(url)) + '.jpg'
    with open(fileName, 'wb') as f:
        f.write(response.content)
