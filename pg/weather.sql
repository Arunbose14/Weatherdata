PGDMP  :    %                |            Weather    16.1    16.1     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    27871    Weather    DATABASE     |   CREATE DATABASE "Weather" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_India.1252';
    DROP DATABASE "Weather";
                postgres    false            �            1259    27874    weatherdata    TABLE     �   CREATE TABLE public.weatherdata (
    id integer NOT NULL,
    location character varying(100),
    temperature double precision,
    description character varying(255),
    icon character varying(10),
    date timestamp without time zone
);
    DROP TABLE public.weatherdata;
       public         heap    postgres    false            �            1259    27873    weatherdata_id_seq    SEQUENCE     �   CREATE SEQUENCE public.weatherdata_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.weatherdata_id_seq;
       public          postgres    false    216            �           0    0    weatherdata_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.weatherdata_id_seq OWNED BY public.weatherdata.id;
          public          postgres    false    215            P           2604    27877    weatherdata id    DEFAULT     p   ALTER TABLE ONLY public.weatherdata ALTER COLUMN id SET DEFAULT nextval('public.weatherdata_id_seq'::regclass);
 =   ALTER TABLE public.weatherdata ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    215    216    216            �          0    27874    weatherdata 
   TABLE DATA           Y   COPY public.weatherdata (id, location, temperature, description, icon, date) FROM stdin;
    public          postgres    false    216   P       �           0    0    weatherdata_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.weatherdata_id_seq', 56, true);
          public          postgres    false    215            R           2606    27879    weatherdata weatherdata_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.weatherdata
    ADD CONSTRAINT weatherdata_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.weatherdata DROP CONSTRAINT weatherdata_pkey;
       public            postgres    false    216            �   �   x���A
�0EדSx�d�Ij�P)���ƚ�R1����Y
����	�i��
M���pi�aɘ�:��=��3ܶ0�-���ֆ>/Eq��N"C߾#0N@H�D.���++�U�H�>�J��1�g��nL�� ����k�ZI�h+-��=���+�g�'�z7�?��%+��F4R�=-L�     