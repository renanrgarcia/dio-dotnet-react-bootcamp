import React from "react";

import {
    HeaderContainer,
    Column,
    Row,
    Wrapper,
    Input,
    BuscarInputContainer,
    Container,
    Menu, 
    MenuRight,
    UserPicture
} from "./styles";
import { Button } from "../Button";

const Header = ({title, variant="primary", onClick}) => {
    return (
        <Wrapper>
            <Container>
                <Row>
                    <MenuRight href='#'>Home</MenuRight>
                    <Button title="Entrar" />
                    <Button title="Cadastrar" />
                </Row>
            </Container>
        </Wrapper>
    );
}

export { Header };