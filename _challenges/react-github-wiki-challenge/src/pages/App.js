import { useState } from 'react';
import githubLogo from '../assets/github-logo.png';
import { Container } from './styles.js';
import Input from '../components/Input';
import ItemRepo from '../components/ItemRepo';
import Button from '../components/Button';
import { api } from '../services/api.js';

function App() {
  const [currentRepo, setCurrentRepo] = useState('');
  const [repos, setRepos] = useState([]);

  const handleSearchRepo = async () => {
    try{
      const { data } = await api.get(`repos/${currentRepo}`);

      if (data.id) {

        const isExist = repos.find(repo => repo.id === data.id);

        if (!isExist){
          setRepos(prev => [...prev, data]);
          return
        }
        alert('Repositório ja foi adicionado!')
      }
    }
    catch (error) {
      if (error.response && error.response.status === 404) {
        alert('Repositório não encontrado!') 
      } else {
        console.error('Um erro inesperado aconteceu:', error);
        alert('An unexpected error occurred.');
      }
    }
  }

  const handleRemoveRepo = (id) => {
    setRepos((prevRepos) => {
      return prevRepos.filter((repo) => repo.id !== id)
    });
  }

  return (
    <Container>
        <img src={githubLogo} width={72} height={72} />
        <Input value={currentRepo} onChange={(e) => setCurrentRepo(e.target.value)}/>
        <Button onClick={handleSearchRepo}/>
        {repos.map(repo => <ItemRepo handleRemoveRepo={handleRemoveRepo} repo={repo}/>)}
    </Container>
  );
}

export default App;
