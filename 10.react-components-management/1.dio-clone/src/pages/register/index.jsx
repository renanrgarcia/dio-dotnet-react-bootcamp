import React from 'react'
import { useNavigate  } from "react-router-dom";
import { useForm } from "react-hook-form";
import { Card } from '../../components/Card';
import { UserInfo } from '../../components/UserInfo';
import { MdEmail, MdLock, MdPerson } from 'react-icons/md'

import { Header } from '../../components/Header';

import { Container, Column, Title, TitleHighlight, SubtitleLogin, Wrapper, Wrapper2, EsqueciText, CriarText } from './styles';
import { Input } from '../../components/Input';
import { Button } from '../../components/Button';
import { api } from '../../services/api';

const Register = () => {
  const navigate = useNavigate()

  const { control, handleSubmit, formState: { errors  } } = useForm({
      reValidateMode: 'onChange',
      mode: 'onChange',
  });

  const onSubmit = async (formData) => {
    try{
      const {data} = await api.get(`/users?email=${formData.email}&senha=${formData.senha}`);
      
      if(data.length && data[0].id){
          navigate('/feed') 
          return
      }

      alert('Usuário ou senha inválido')
    }catch(e){
      //TODO: HOUVE UM ERRO
    }
  };

  return (
  <>
    <Header autenticado={false}/>
    <Container>
      <Wrapper2>
        <Column>
          <Title>A plataforma para você aprender com experts, dominar as principais 
            tecnologias e entrar mais rápido nas empresas mais desejadas.</Title>
        </Column>
      </Wrapper2>
      <Wrapper>
        <Title>Comece agora grátis</Title>
        <SubtitleLogin>Crie sua conta e make the change._</SubtitleLogin>
        <form onSubmit={handleSubmit(onSubmit)}>
          <Input placeholder="Nome completo" leftIcon={<MdPerson />} name="nome"  control={control} />
          {errors.nome && <span>Nome é obrigatório</span>}
          <Input placeholder="E-mail" leftIcon={<MdEmail />} name="email"  control={control} />
          {errors.email && <span>E-mail é obrigatório</span>}
          <Input type="password" placeholder="Senha" leftIcon={<MdLock />}  name="senha" control={control} />
          {errors.senha && <span>Senha é obrigatório</span>}
          <Button title="Criar minha conta" variant="secondary" type="submit"/>
        </form>
        <SubtitleLogin>Ao clicar em "criar minha conta grátis", declaro que aceito as Políticas de Privacidade e os Termos de Uso da DIO.</SubtitleLogin>
        <EsqueciText>Já tenho conta</EsqueciText><CriarText>Criar Conta</CriarText>
      </Wrapper>
    </Container>
  </>
  )
}

export { Register }; 